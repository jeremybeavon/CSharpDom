using CSharpDom.CodeAnalysis;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.Generator
{
    public static class BaseClassGenerator
    {
        public static async Task GenerateBaseClass(DocumentWithCodeAnalysis document)
        {
            string filePath = document.FullFilePath;
            string destinationPath = Path.Combine(
                Path.GetDirectoryName(filePath).Replace(@"CSharpDom\Common", @"CSharpDom\BaseClasses"),
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

            InterfaceWithCodeAnalysis @interface = @namespace.Interfaces.First();
            if (@interface.GenericParameters.Count == 0)
            {
                return;
            }

            Console.WriteLine($"Writing: {Path.GetFileName(destinationPath)}");
            string namespaceName = @namespace.Name;
            using (CodeAnalysisSettings.AllowEdits(loadedDocument))
            {
                LoadedDocumentWithCodeAnalysis newDocument = new LoadedDocumentWithCodeAnalysis();
                newDocument.UsingDirectives.Add(new UsingDirectiveWithCodeAnalysis(namespaceName));
                DocumentWithCodeAnalysis baseClassDocument = document.Project.AddDocument(
                    destinationPath,
                    newDocument);
                NamespaceWithCodeAnalysis newNamespace = new NamespaceWithCodeAnalysis(
                    baseClassDocument,
                    namespaceName.Replace("Common", "BaseClasses"));
                AbstractClassWithCodeAnalysis baseClass = new AbstractClassWithCodeAnalysis(
                    baseClassDocument,
                    TypeVisibilityModifier.Public,
                    GetNewName(@interface.Name))
                {
                    GenericParameters = @interface.GenericParameters,
                    BaseClass = new ClassReferenceWithCodeAnalysis("AbstractExpression")
                };
                ITypeReferenceWithCodeAnalysis[] implementedInterfaceGenericParameters =
                    @interface.GenericParameters
                   .Select(parameter => new GenericParameterReferenceWithCodeAnalysis(parameter.Name))
                   .ToArray();
                baseClass.ImplementedInterfaces.Add(
                    new InterfaceReferenceWithCodeAnalysis(@interface.Name, implementedInterfaceGenericParameters));
                newNamespace.Classes.AbstractClasses.Add(baseClass);
                newDocument.Namespaces.Add(newNamespace);
                await baseClass.ImplementInterface(@class => @class.ImplementedInterfaces.First(), baseClassDocument);
                foreach (AbstractClassPropertyWithCodeAnalysis property in baseClass.Properties)
                {

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

        private static string GetNewName(string name)
        {
            return Regex.Replace(name, "^I", "Abstract");
        }
    }
}
