using CSharpDom.CodeAnalysis;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.Generator
{
    public static class EditableInterfaceGenerator
    {
        public static async Task GenerateEditableInterface(DocumentWithCodeAnalysis document)
        {
            string filePath = document.FullFilePath;
            string destinationPath = Path.Combine(
                    Path.GetDirectoryName(filePath).Replace(@"CSharpDom\Common", @"CSharpDom\Common\Editable"),
                    GetNewName(Path.GetFileName(filePath)));
            if (File.Exists(destinationPath))
            {
                return;
            }

            LoadedDocumentWithCodeAnalysis loadedDocument = await document.LoadAsync();
            NamespaceWithCodeAnalysis @namespace = loadedDocument.Namespaces.First();
            if (@namespace.Interfaces.Count == 0)
            {
                return;
            }

            Console.WriteLine($"Writing: {Path.GetFileName(destinationPath)}");
            string namespaceName = @namespace.Name;
            using (CodeAnalysisSettings.AllowEdits(loadedDocument))
            {
                EditUsingDirectives(loadedDocument, namespaceName);
                @namespace.Name = Regex.Replace(namespaceName, "^CSharpDom.Common", "CSharpDom.Common.Editable");
                InterfaceWithCodeAnalysis @interface = @namespace.Interfaces.First();
                string interfaceName = @interface.Name;
                @interface.Name = GetNewName(interfaceName);
                List<ITypeReferenceWithCodeAnalysis> genericParameters = EditInterfaceGenericParameters(@interface);
                EditInterfaceBaseInterfaces(@interface, interfaceName, genericParameters);
                EditInterfaceProperties(@interface);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
            const int maximumLineLength = 120;
            string sourceCode = loadedDocument.ToSourceCode(
                new IndentBaseTypeListIfTooLongRule(maximumLineLength),
                new IndentGenericParamterDefinitionsIfTooLongRule(maximumLineLength),
                new IndentMethodParametersIfTooLongRule(maximumLineLength));
            File.WriteAllText(destinationPath, sourceCode);
        }

        private static void EditUsingDirectives(
            LoadedDocumentWithCodeAnalysis loadedDocument,
            string namespaceName)
        {
            List<UsingDirectiveWithCodeAnalysis> usingDirectives = loadedDocument.UsingDirectives.ToList();
            foreach (UsingDirectiveWithCodeAnalysis directive in usingDirectives)
            {
                string directiveName = directive.Name;
                if (directiveName.Contains("CSharpDom.Common."))
                {
                    directive.Name = directiveName.Replace("CSharpDom.Common.", "CSharpDom.Common.Editable.");
                }
            }

            if (namespaceName.StartsWith("CSharpDom.Common."))
            {
                UsingDirectiveWithCodeAnalysis usingDirective = new UsingDirectiveWithCodeAnalysis(namespaceName);
                usingDirectives.Insert(
                    ~usingDirectives.BinarySearch(usingDirective, new NameComparer()),
                    usingDirective);
            }

            loadedDocument.UsingDirectives = usingDirectives;
        }

        private static List<ITypeReferenceWithCodeAnalysis> EditInterfaceGenericParameters(
            InterfaceWithCodeAnalysis @interface)
        {
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

            return genericParameters;
        }

        private static void EditInterfaceBaseInterfaces(
            InterfaceWithCodeAnalysis @interface,
            string oldInterfaceName,
            List<ITypeReferenceWithCodeAnalysis> genericParameters)
        {
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

            InterfaceReferenceWithCodeAnalysis interfaceReference = new InterfaceReferenceWithCodeAnalysis(
                oldInterfaceName,
                genericParameters.ToArray());
            @interface.Interfaces.Add(interfaceReference);
        }

        private static void EditInterfaceProperties(InterfaceWithCodeAnalysis @interface)
        {
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

        private static string GetNewName(string name)
        {
            return Regex.Replace(name, "^I(?:Has)?", "$&Editable");
        }
    }
}
