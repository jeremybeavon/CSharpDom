using CSharpDom.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Nito.AsyncEx;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.EditableInterfaceGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AsyncContext.Run(GenerateEditableInterfaces);
        }

        private static async Task GenerateEditableInterfaces()
        {
            string baseDirectory = Path.GetFullPath(
                Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\.."));
            ProjectWithCodeAnalysis project = await ProjectWithCodeAnalysis.OpenAsync(
                Path.Combine(baseDirectory, @"CSharpDom\CSharpDom.csproj"));
            project.Lock();
            foreach (DocumentWithCodeAnalysis document in project.Documents)
            {
                document.IsLocked = true;
                string filePath = document.FullFilePath;
                if (!filePath.Contains(@"CSharpDom\Common") ||
                    filePath.Contains(@"CSharpDom\Common\Editable") ||
                    filePath.Contains(@"CSharpDom\Common\IL") ||
                    filePath.Contains(@"CSharpDom\Common\Trivia") ||
                    !Regex.IsMatch(Path.GetFileName(filePath), "^I[A-Z]"))
                {
                    continue;
                }

                string destinationPath = Path.Combine(
                    Path.GetDirectoryName(filePath).Replace(@"CSharpDom\Common", @"CSharpDom\Common\Editable"),
                    Regex.Replace(Path.GetFileName(filePath), "^I", "IEditable"));
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

                /*NamespaceDeclarationSyntax namespaceSyntax = @namespace.Syntax;
                NameSyntax syntax1 = SyntaxFactory.IdentifierName("jbtest");
                namespaceSyntax = namespaceSyntax.WithName(syntax1);
                NameSyntax syntax2 = namespaceSyntax.Name;*/
                @namespace.Name = Regex.Replace(@namespace.Name, "^CSharpDom.Common", "CSharpDom.Common.Editable");
                string testNamespaceName = @namespace.Name;
                InterfaceWithCodeAnalysis @interface = @namespace.Interfaces.First();
                string interfaceName = @interface.Name;
                List<ITypeReferenceWithCodeAnalysis> genericParameters = new List<ITypeReferenceWithCodeAnalysis>();
                foreach (GenericParameterDeclarationWithCodeAnalysis parameter in @interface.GenericParameters)
                {
                    genericParameters.Add(new GenericParameterReferenceWithCodeAnalysis(parameter.Name));
                    if (parameter.InterfaceConstraints.Count == 0)
                    {
                        continue;
                    }

                    InterfaceReferenceWithCodeAnalysis constraint = parameter.InterfaceConstraints.First();
                    constraint.Name = Regex.Replace(constraint.Name, "^I", "IEditable");
                }
                InterfaceReferenceWithCodeAnalysis interfaceReference = new InterfaceReferenceWithCodeAnalysis(
                    interfaceName,
                    genericParameters.ToArray());
                @interface.Name = Regex.Replace(interfaceName, "^I", "IEditable");
                foreach (InterfaceReferenceWithCodeAnalysis reference in @interface.Interfaces.ToArray())
                {
                    reference.Name = Regex.Replace(reference.Name, "^I", "IEditable");
                }

                @interface.Interfaces.Add(interfaceReference);
                foreach (InterfacePropertyWithCodeAnalysis property in @interface.Properties.ToArray())
                {
                    property.InheritanceModifier = InterfaceMemberInheritanceModifier.New;
                    ITypeReferenceWithCodeAnalysis propertyType = property.PropertyType;
                    PropertyDeclarationSyntax syntax = property.Syntax;
                    property.Syntax = syntax.WithAccessorList(
                        syntax.AccessorList.AddAccessors(SyntaxFactory.AccessorDeclaration(SyntaxKind.SetKeyword)));
                }

                Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));
                File.WriteAllText(destinationPath, loadedDocument.Syntax.ToFullString());
            }
        }
    }
}
