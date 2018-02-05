using CSharpDom.CodeAnalysis;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpDom.GenericChildVisitorGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            AsyncContext.Run(GenerateForwardingVisitor);
        }

        private static async Task GenerateForwardingVisitor()
        {
            string visitorFileName = Path.Combine(
                Path.GetDirectoryName(typeof(Program).Assembly.Location),
                @"..\..\..\..CSharpDom\Common\Editable\ForwardingEditableVisitor.cs");
            visitorFileName = Path.GetFullPath(visitorFileName);
            LoadedDocumentWithCodeAnalysis loadedDocument =
                await LoadedDocumentWithCodeAnalysis.LoadFromFileAsync(visitorFileName);
            StaticClassWithCodeAnalysis visitorClass = loadedDocument.Classes.StaticClasses.First();
            using (CodeAnalysisSettings.AllowEdits(visitorClass))
            {
                foreach (StaticClassMethodWithCodeAnalysis method in
                    visitorClass.Methods.Where(method => method.GenericParameters.LastOrDefault()?.Name != "TVisitor"))
                {
                    ITypeReferenceWithCodeAnalysis visitableType = method.Parameters[0].ParameterType;
                    string newName = Regex.Replace(visitableType.Name, "^I", "T");
                    //method.GenericParameters.Insert(0, new GenericParameterDeclarationWithCodeAnalysis())
                }
            }

            const int maximumLineLength = 120;
            string sourceCode = loadedDocument.ToSourceCode(
                new IndentMethodParametersIfTooLongRule(maximumLineLength));
            File.WriteAllText(visitorFileName, sourceCode);
        }
    }
}
