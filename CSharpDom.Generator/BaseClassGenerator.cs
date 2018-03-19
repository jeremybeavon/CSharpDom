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
            if (@namespace.Interfaces.Count == 0 && @namespace.Interfaces.First().GenericParameters.Count > 0)
            {
                return;
            }

            Console.WriteLine($"Writing: {Path.GetFileName(destinationPath)}");
            string namespaceName = @namespace.Name;
            using (CodeAnalysisSettings.AllowEdits(loadedDocument))
            {
                //EditUsingDirectives(loadedDocument, namespaceName);
                @namespace.Name = Regex.Replace(namespaceName, "^CSharpDom.Common", "CSharpDom.Common.Editable");
                InterfaceWithCodeAnalysis @interface = @namespace.Interfaces.First();
                string interfaceName = @interface.Name;
                @interface.Name = GetNewName(interfaceName);
                //List<ITypeReferenceWithCodeAnalysis> genericParameters = EditInterfaceGenericParameters(@interface);
                //EditInterfaceBaseInterfaces(@interface, interfaceName, genericParameters);
                //EditInterfaceProperties(@interface);
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
