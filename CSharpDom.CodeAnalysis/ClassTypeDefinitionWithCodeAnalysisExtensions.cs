using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeActions;
using Microsoft.CodeAnalysis.CodeFixes;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public static class ClassTypeDefinitionWithCodeAnalysisExtensions
    {
        private const string ImplementInterfaceName = "ImplementInterface";

        public static async Task ImplementInterfaceAsync(
            this IClassTypeDefinitionWithCodeAnalysis definition,
            Func<IClassTypeDefinitionWithCodeAnalysis, InterfaceReferenceWithCodeAnalysis> reference,
            DocumentWithCodeAnalysis document)
        {
            List<CodeAction> actions = new List<CodeAction>();
            DiagnosticDescriptor descriptor =
                new DiagnosticDescriptor("CS0535", "CS0535", "CS0535", "CS0535", DiagnosticSeverity.Error, true);
            NameSyntax syntax = reference(definition).Syntax;
            CodeFixContext context = new CodeFixContext(
                document.Syntax,
                Diagnostic.Create(descriptor, Location.Create(syntax.SyntaxTree, syntax.Span)),
                (action, diagnostics) => actions.Add(action),
                CancellationToken.None);
            await CodeAnalysisCodeFixProvider.GetCodeFixProvider(ImplementInterfaceName).RegisterCodeFixesAsync(context);
            var operations = await actions[0].GetOperationsAsync(CancellationToken.None);
            foreach (var operation in operations)
            {
                operation.Apply(document.Solution.Syntax.Workspace, CancellationToken.None);
            }
        }
    }
}
