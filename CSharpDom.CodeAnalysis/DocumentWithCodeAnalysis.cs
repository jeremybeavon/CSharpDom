using System;
using System.Threading.Tasks;
using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        public bool IsLocked
        {
            get { return node.IsLocked; }
            set { node.IsLocked = value; }
        }

        INode<Document> IHasNode<Document>.Node
        {
            get { return node; }
        }

        public override async Task<LoadedDocumentWithCodeAnalysis> LoadAsync()
        {
            return new LoadedDocumentWithCodeAnalysis(this, (CompilationUnitSyntax)await Syntax.GetSyntaxRootAsync());
        }
    }
}
