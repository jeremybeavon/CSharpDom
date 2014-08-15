using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpDom.Builder;
using CSharpDom.Common;
using CSharpDom.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom
{
    internal abstract class ProjectNode : AbstractAsyncNode
    {
        private readonly AsyncLazyLoadedEnumerable<DocumentNode, AnalyzedDocument> analyzedDocuments;

        protected ProjectNode(Project project, SolutionNode solution)
        {
            Project = project;
            Solution = solution;
            Documents = project.Documents.Select(CreateDocumentNode).ToArray();
            analyzedDocuments = new AsyncLazyLoadedEnumerable<DocumentNode, AnalyzedDocument>(
                Documents,
                AnalyzeDocumentAsync,
                analyzedDocument => analyzedDocument.Document);
            Namespaces = CreateAsyncEnumerable(analyzedDocument => analyzedDocument.Namespaces);
            Classes = CreateAsyncEnumerable(analyzedDocument => analyzedDocument.Classes);
            Delegates = CreateAsyncEnumerable(analyzedDocument => analyzedDocument.Delegates);
            Enums = CreateAsyncEnumerable(analyzedDocument => analyzedDocument.Enums);
            Interfaces = CreateAsyncEnumerable(analyzedDocument => analyzedDocument.Interfaces);
            Structs = CreateAsyncEnumerable(analyzedDocument => analyzedDocument.Structs);
        }

        public SolutionNode Solution { get; private set; }

        public Project Project { get; private set; }

        public IReadOnlyCollection<DocumentNode> Documents { get; private set; }

        public IAsyncEnumerable<NamespaceNode, DocumentNode> Namespaces { get; private set; }

        public IAsyncEnumerable<ClassNode, DocumentNode> Classes { get; private set; }

        public IAsyncEnumerable<DelegateNode, DocumentNode> Delegates { get; private set; }

        public IAsyncEnumerable<EnumNode, DocumentNode> Enums { get; private set; }

        public IAsyncEnumerable<InterfaceNode, DocumentNode> Interfaces { get; private set; }

        public IAsyncEnumerable<StructNode, DocumentNode> Structs { get; private set; }

        public override async Task AcceptAsync(NodeVisitor visitor)
        {
            NodeVisitor.VisitCollection(Documents, visitor.VisitDocument);
            foreach (NamespaceNode node in await Namespaces.GetAll())
            {
                visitor.VisitNamespace(node);
            }
        }

        protected virtual Task<INodeFactory> GetNodeFactory(DocumentNode document)
        {
            return Task.FromResult(Solution.NodeFactory);
        }

        private async Task<AnalyzedDocument> AnalyzeDocumentAsync(DocumentNode document)
        {
            CSharpSyntaxNode node = await document.Document.GetSyntaxRootAsync() as CSharpSyntaxNode;
            SyntaxBuilder builder = new SyntaxBuilder(await GetNodeFactory(document), document);
            node.Accept(builder);
            return new AnalyzedDocument(document, builder.NamespacesByName.Values.ToArray());
        }

        private IAsyncEnumerable<T, DocumentNode> CreateAsyncEnumerable<T>(
            Func<AnalyzedDocument, IEnumerable<T>> selectFunc)
        {
            return new DocumentNodeAsyncEnumerable<T>(analyzedDocuments, selectFunc);
        }

        private DocumentNode CreateDocumentNode(Document document)
        {
            return Solution.NodeFactory.CreateDocumentNode(document, this);
        }
    }
}
