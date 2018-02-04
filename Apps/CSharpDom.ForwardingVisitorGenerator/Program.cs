using CSharpDom.CodeAnalysis;
using CSharpDom.CodeAnalysis.Statements;
using CSharpDom.Common.Statements;
using CSharpDom.Text;
using CSharpDom.Text.Rules;
using Nito.AsyncEx;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.ForwardingVisitorGenerator
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
            SealedClassWithCodeAnalysis visitorClass = loadedDocument.Classes.SealedClasses.First();
            using (CodeAnalysisSettings.AllowEdits(visitorClass))
            {
                foreach (SealedClassMethodWithCodeAnalysis method in
                    visitorClass.Methods.Where(method => method.Body.Statements.FirstOrDefault() is IThrowStatement))
                {
                    
                }
            }

            const int maximumLineLength = 120;
            string sourceCode = loadedDocument.ToSourceCode(
                new IndentMethodParametersIfTooLongRule(maximumLineLength));
            File.WriteAllText(visitorFileName, sourceCode);
        }
    }
}
