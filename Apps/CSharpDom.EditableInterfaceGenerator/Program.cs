using CSharpDom.CodeAnalysis;
using CSharpDom.CodeAnalysis.Expressions;
using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using Nito.AsyncEx;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.EditableInterfaceGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AsyncContext.Run(GenerateEditableWrappers);
        }

        private static string GetNewName(string name)
        {
            return "Editable" + name;
        }

        private static async Task GenerateEditableWrappers()
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
                if (!filePath.Contains(@"CSharpDom\BaseClasses\Wrappers"))
                {
                    continue;
                }

                string newDirectory = Path.GetDirectoryName(filePath)
                    .Replace(@"CSharpDom\BaseClasses\Wrappers", @"CSharpDom\BaseClasses\Editable\Wrappers");
                string destinationPath = Path.Combine(newDirectory, GetNewName(Path.GetFileName(filePath)));
                if (File.Exists(destinationPath))
                {
                    continue;
                }

                LoadedDocumentWithCodeAnalysis loadedDocument = await document.LoadAsync();
                NamespaceWithCodeAnalysis @namespace = loadedDocument.Namespaces.First();
                Console.WriteLine($"Writing: {Path.GetFileName(destinationPath)}");
                string namespaceName = @namespace.Name;
                using (CodeAnalysisSettings.AllowEdits(loadedDocument))
                {
                    foreach (UsingDirectiveWithCodeAnalysis directive in loadedDocument.UsingDirectives)
                    {
                        directive.Name = directive.Name.Replace("CSharpDom.Common", "CSharpDom.Common.Editable");
                    }

                    loadedDocument.UsingDirectives.Add(new UsingDirectiveWithCodeAnalysis("CSharpDom.Common"));
                    loadedDocument.UsingDirectives = loadedDocument.UsingDirectives
                        .OrderBy(directive => directive.Name)
                        .ToArray();
                    @namespace.Name = "CSharpDom.BaseClasses.Editable.Wrappers";
                    SealedClassWithCodeAnalysis @class = @namespace.Classes.SealedClasses.First();
                    @class.Name = "Editable" + @class.Name;
                    @class.BaseClass.Name = Regex.Replace(@class.BaseClass.Name, "^Abstract", "Editable");
                    ITypeReferenceWithCodeAnalysis interfaceReference =
                        @class.ImplementedInterfaces.First().GenericParameters[0];
                    interfaceReference.Name = Regex.Replace(interfaceReference.Name, "^I", "IEditable");
                    foreach (GenericParameterDeclarationWithCodeAnalysis genericParameter in @class.GenericParameters)
                    {
                        InterfaceReferenceWithCodeAnalysis constraint = genericParameter.InterfaceConstraints.First();
                        constraint.Name = Regex.Replace(constraint.Name, "^I", "IEditable");
                    }

                    ITypeReferenceWithCodeAnalysis constructorParameterType =
                        @class.Constructors.First().Parameters[0].ParameterType;
                    constructorParameterType.Name = Regex.Replace(constructorParameterType.Name, "^I", "IEditable");
                    foreach (SealedClassAutoPropertyWithCodeAnalysis property in @class.Properties.AutoProperties)
                    {
                        if (property.Name == "WrappedObject")
                        {
                            //CodeAnalysisLogger.StartLoggingDebugMessages();
                            property.PropertyType.Name = Regex.Replace(property.PropertyType.Name, "^I", "IEditable");
                            //string[] logMessages = CodeAnalysisLogger.GetDebugLogMessages();
                            //CodeAnalysisLogger.StopLoggingDebugMessages();
                            break;
                        }
                    }

                    foreach (SealedClassPropertyWithCodeAnalysis property in @class.Properties)
                    {
                        string propertyName = property.Name;
                        if (propertyName == "WrappedObject")
                        {
                            continue;
                        }

                        string propertyTypeName = property.PropertyType.Name;
                        if (propertyTypeName.Contains("ReadOnly"))
                        {
                            property.PropertyType.Name = propertyTypeName.Replace("ReadOnly", string.Empty);
                        }

                        IExpressionWithCodeAnalysis expression = ExpressionFactory.Binary(
                            ExpressionFactory.Member(ExpressionFactory.Identifier("WrappedObject"), propertyName),
                            BinaryOperatorExpressionType.Assign,
                            ExpressionFactory.Identifier("value"));
                        property.SetAccessor = new ClassAccessorWithCodeAnalysis(
                            AccessorType.Set,
                            new MethodBodyWithCodeAnalysis(StatementFactory.Expression(expression)));
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
        }
    }
}

/*
 * if (Regex.IsMatch(interfaceName, "^IGeneric.*Visitor-$"))
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
*/