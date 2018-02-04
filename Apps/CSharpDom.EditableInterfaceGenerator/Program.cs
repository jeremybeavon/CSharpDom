using CSharpDom.CodeAnalysis;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.EditableInterfaceGenerator
{
    public class Program : IComparer<UsingDirectiveWithCodeAnalysis>
    {
        public static void Main(string[] args)
        {
            AsyncContext.Run(GenerateEditableInterfaces);
        }

        private static string GetNewName(string name)
        {
            return Regex.Replace(name, "^I(?:Has)?", "$&Editable");
        }

        private static async Task GenerateEditableInterfaces()
        {
            string baseDirectory = Path.GetFullPath(
                Path.Combine(Path.GetDirectoryName(typeof(Program).Assembly.Location), @"..\..\..\.."));
            ProjectWithCodeAnalysis project = await ProjectWithCodeAnalysis.OpenAsync(
                Path.Combine(baseDirectory, @"CSharpDom\CSharpDom.csproj"));
            project.Lock();
            foreach (DocumentWithCodeAnalysis document in project.Documents.OrderBy(document => document.FullFilePath))
            {
                document.IsLocked = true;
                string filePath = document.FullFilePath;
                if (!filePath.Contains(@"CSharpDom\Common") ||
                    filePath.Contains(@"CSharpDom\Common\Editable") ||
                    filePath.Contains(@"CSharpDom\Common\IL\") ||
                    filePath.Contains(@"CSharpDom\Common\Trivia") ||
                    !Regex.IsMatch(Path.GetFileName(filePath), "^I[A-Z]"))
                {
                    continue;
                }

                string destinationPath = Path.Combine(
                    Path.GetDirectoryName(filePath).Replace(@"CSharpDom\Common", @"CSharpDom\Common\Editable"),
                    GetNewName(Path.GetFileName(filePath)));
                if (File.Exists(destinationPath))
                {
                    continue;
                }

                LoadedDocumentWithCodeAnalysis loadedDocument = await document.LoadAsync();
                NamespaceWithCodeAnalysis @namespace = loadedDocument.Namespaces.First();
                if (@namespace.Interfaces.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"Writing: {Path.GetFileName(destinationPath)}");
                string namespaceName = @namespace.Name;
                using (CodeAnalysisSettings.AllowEdits(loadedDocument))
                {
                    List<UsingDirectiveWithCodeAnalysis> usingDirectives = loadedDocument.UsingDirectives
                        .Select(directive => { directive.Name = directive.Name.Replace("CSharpDom.Common.", "CSharpDom.Common.Editable."); return directive; })
                        .ToList();
                    if (namespaceName.StartsWith("CSharpDom.Common."))
                    {
                        UsingDirectiveWithCodeAnalysis usingDirective = new UsingDirectiveWithCodeAnalysis(namespaceName);
                        usingDirectives.Insert(
                            ~usingDirectives.BinarySearch(usingDirective, new Program()),
                            usingDirective);                        
                    }

                    loadedDocument.UsingDirectives = usingDirectives;
                    @namespace.Name = Regex.Replace(namespaceName, "^CSharpDom.Common", "CSharpDom.Common.Editable");
                    InterfaceWithCodeAnalysis @interface = @namespace.Interfaces.First();
                    string interfaceName = @interface.Name;
                    if (Regex.IsMatch(interfaceName, "^IGeneric.*Visitor$"))
                    {
                        destinationPath = destinationPath.Replace("Generic", "Editable");
                        @interface.Name = interfaceName.Replace("Generic", "Editable");
                        foreach (InterfaceMethodWithCodeAnalysis method in @interface.Methods)
                        {
                            UnspecifiedTypeReferenceWithCodeAnalysis parameterType =
                                method.Parameters[0].ParameterType as UnspecifiedTypeReferenceWithCodeAnalysis;
                            if (method.Name == "Visit" || method.Name == "VisitAsync")
                            {
                                UnspecifiedTypeReferenceWithCodeAnalysis genericParameterType =
                                    parameterType.GenericParameters[0] as UnspecifiedTypeReferenceWithCodeAnalysis;
                                genericParameterType.Name = genericParameterType.Name.Replace("Generic", "Editable");
                                continue;
                            }

                            foreach (GenericParameterDeclarationWithCodeAnalysis parameter in method.GenericParameters)
                            {
                                InterfaceReferenceWithCodeAnalysis constraint = parameter.InterfaceConstraints.FirstOrDefault();
                                if (constraint != null)
                                {
                                    constraint.Name = GetNewName(constraint.Name);
                                }
                            }

                            parameterType.Name = GetNewName(parameterType.Name);
                        }
                    }
                    else
                    {
                        @interface.Name = GetNewName(interfaceName);
                        List<ITypeReferenceWithCodeAnalysis> genericParameters = new List<ITypeReferenceWithCodeAnalysis>();
                        foreach (GenericParameterDeclarationWithCodeAnalysis parameter in @interface.GenericParameters)
                        {
                            genericParameters.Add(new GenericParameterReferenceWithCodeAnalysis(parameter.Name));
                            if (parameter.InterfaceConstraints.Count == 0)
                            {
                                continue;
                            }

                            InterfaceReferenceWithCodeAnalysis constraint = parameter.InterfaceConstraints.First();
                            constraint.Name = GetNewName(constraint.Name);
                        }

                        InterfaceReferenceWithCodeAnalysis interfaceReference = new InterfaceReferenceWithCodeAnalysis(
                            interfaceName,
                            genericParameters.ToArray());
                        foreach (InterfaceReferenceWithCodeAnalysis reference in @interface.Interfaces.ToArray())
                        {
                            string referenceName = reference.Name;
                            if (referenceName == "IVisitable")
                            {
                                UnspecifiedTypeReferenceWithCodeAnalysis genericParameterType =
                                    reference.GenericParameters[0] as UnspecifiedTypeReferenceWithCodeAnalysis;
                                genericParameterType.Name = genericParameterType.Name.Replace("Generic", "Editable");
                            }
                            else
                            {
                                reference.Name = GetNewName(referenceName);
                            }
                        }

                        @interface.Interfaces.Add(interfaceReference);
                        foreach (InterfacePropertyWithCodeAnalysis property in @interface.Properties.ToArray())
                        {
                            PropertyDeclarationSyntax syntax = property.Syntax;
                            property.Syntax = syntax.WithAccessorList(
                                syntax.AccessorList.AddAccessors(SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)));
                            property.InheritanceModifier = InterfaceMemberInheritanceModifier.New;
                            if (property.PropertyType is UnspecifiedTypeReferenceWithCodeAnalysis propertyType)
                            {
                                string propertyTypeName = propertyType.Name;
                                if (propertyTypeName.StartsWith("IReadOnly"))
                                {
                                    propertyType.Name = propertyTypeName.Replace("ReadOnly", string.Empty);
                                }
                            }
                        }
                    }
                }

                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                const int maximumLineLength = 120;
                string sourceCode = loadedDocument.ToSourceCode(
                    new IndentBaseTypeListIfTooLongRule(maximumLineLength),
                    new IndentGenericParamterDefinitionsIfTooLongRule(maximumLineLength),
                    new IndentMethodParametersIfTooLongRule(maximumLineLength));
                File.WriteAllText(destinationPath, sourceCode);
            }
        }

        public int Compare(UsingDirectiveWithCodeAnalysis x, UsingDirectiveWithCodeAnalysis y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
