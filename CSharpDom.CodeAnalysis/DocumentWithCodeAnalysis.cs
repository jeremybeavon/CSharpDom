using System;
using System.Threading.Tasks;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DocumentWithCodeAnalysis :
        EditableDocument<ProjectWithCodeAnalysis, SolutionWithCodeAnalysis, LoadedDocumentWithCodeAnalysis>,
        IHasSyntax<Document>,
        IHasNode<Document>
    {
        private readonly Node<DocumentWithCodeAnalysis, Document> node;

        public DocumentWithCodeAnalysis()
        {
            node = new Node<DocumentWithCodeAnalysis, Document>(this);
        }

        public override string FullFilePath
        {
            get { return Syntax.FilePath; }
            set { throw new NotSupportedException(); }
        }

        public override ProjectWithCodeAnalysis Project
        {
            get { return node.GetParentNode<ProjectWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return Project?.Solution; }
            set { throw new NotSupportedException(); }
        }

        public Document Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<Document> IHasNode<Document>.Node
        {
            get { return node; }
        }

        public override Task<LoadedDocumentWithCodeAnalysis> LoadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
