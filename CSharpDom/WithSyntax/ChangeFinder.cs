using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpDom.WithSyntax.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace CSharpDom.WithSyntax
{
    public static class ChangeFinder
    {
        public static Task<IEnumerable<AbstractSyntaxNode>> FindChangesAsync(string oldText, string newText)
        {
            return FindChangesInternalAsync(
                SyntaxFactory.CreateSolutionNodeForText(newText).Projects.First().Documents.First(),
                CSharpSyntaxTree.ParseText(SourceText.From(oldText)));
        }

        public static async Task<IEnumerable<AbstractSyntaxNode>> FindChangesForSingleDocumentSolutionAsync(
            SolutionWithSyntax oldSolution,
            SolutionWithSyntax newSolution)
        {
            return await FindChangesInternalAsync(
                (DocumentNode)newSolution.Projects.First().Documents.First().AsInterface(),
                await oldSolution.Projects.First().Documents.First().Document.GetSyntaxTreeAsync());
        }

        private static async Task<IEnumerable<AbstractSyntaxNode>> FindChangesInternalAsync(
            DocumentNode newDocument,
            SyntaxTree oldTree)
        {
            SyntaxTree newTree = await newDocument.Document.GetSyntaxTreeAsync();
            SyntaxNode root = await newTree.GetRootAsync();
            IDictionary<SyntaxNode, AbstractSyntaxNode> matchedNodes = new Dictionary<SyntaxNode, AbstractSyntaxNode>();
            IList<TextChange> changes = newTree.GetChanges(oldTree);
            foreach (TextChange change in changes)
            {
                TextSpan changeSpan = change.Span;
                if (changeSpan.Length == 0)
                {
                    changeSpan = new TextSpan(changeSpan.Start, 1);
                }

                SyntaxNode changedMember = root.DescendantNodes(changeSpan, node => !(node is BlockSyntax)).LastOrDefault();
                while (changedMember != null && !(changedMember is MemberDeclarationSyntax))
                {
                    changedMember = changedMember.Parent;
                }

                if (changedMember != null && !matchedNodes.ContainsKey(changedMember))
                {
                    MemberFinder memberFinder = new MemberFinder(changedMember);
                    await newDocument.Project.AcceptAsync(memberFinder);
                    if (memberFinder.MatchedNode != null)
                    {
                        matchedNodes.Add(changedMember, memberFinder.MatchedNode.CreateNode());
                    }
                    else
                    {
                    }
                }
            }

            return matchedNodes.Values;
        }
    }
}
