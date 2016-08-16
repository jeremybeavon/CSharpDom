using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.Builder;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class ProjectNode : AbstractAsyncNode
    {
        protected ProjectNode(Project project, SolutionNode solution)
        {
            Project = project;
            Solution = solution;
            Documents = project.Documents.Select(CreateDocumentNode).ToArray();    
        }

        public SolutionNode Solution { get; private set; }

        public Project Project { get; private set; }

        public IReadOnlyCollection<DocumentNode> Documents { get; private set; }
        
        public override async Task AcceptAsync(NodeVisitor visitor)
        {
            NodeVisitor.VisitCollection(Documents, visitor.VisitDocument);
            /*foreach (NamespaceNode node in await Namespaces.GetAll())
            {
                visitor.VisitNamespace(node);
            }*/
        }

        public Task<LoadedProjectNode> LoadAsync()
        {
            return null;
        }

        protected virtual Task<INodeFactory> GetNodeFactory(DocumentNode document)
        {
            return Task.FromResult(Solution.NodeFactory);
        }

        /*private async Task<AnalyzedDocument> AnalyzeDocumentAsync(DocumentNode document)
        {
            CSharpSyntaxNode node = await document.Document.GetSyntaxRootAsync() as CSharpSyntaxNode;
            SyntaxBuilder builder = new SyntaxBuilder(await GetNodeFactory(document), document);
            node.Accept(builder);
            return new AnalyzedDocument(document, builder.NamespacesByName.Values.ToArray());
        }*/
        
        private DocumentNode CreateDocumentNode(Document document)
        {
            return Solution.NodeFactory.CreateDocumentNode(document, this);
        }
    }
}
