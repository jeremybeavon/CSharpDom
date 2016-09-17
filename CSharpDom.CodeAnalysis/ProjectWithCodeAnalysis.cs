using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ProjectWithCodeAnalysis :
        EditableProject<SolutionWithCodeAnalysis, DocumentWithCodeAnalysis, LoadedProjectWithCodeAnalysis>,
        IHasSyntax<Project>,
        IHasNode<Project>
    {
        private readonly Node<ProjectWithCodeAnalysis, Project> node;
        private readonly ImmutableListWrapper<ProjectWithCodeAnalysis, Project, DocumentWithCodeAnalysis, Document> documents;

        public ProjectWithCodeAnalysis()
        {
            node = new Node<ProjectWithCodeAnalysis, Project>(this);
            documents = new ImmutableListWrapper<ProjectWithCodeAnalysis, Project, DocumentWithCodeAnalysis, Document>(
                node,
                new DocumentListWrapper(node),
                () => new DocumentWithCodeAnalysis());
        }

        public override ICollection<DocumentWithCodeAnalysis> Documents
        {
            get { return documents; }
            set { throw new NotSupportedException(); }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return node.GetParentNode<SolutionWithCodeAnalysis>(); }
            set { throw new NotSupportedException(); }
        }

        public Project Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<Project> IHasNode<Project>.Node
        {
            get { return node; }
        }

        public override Task<LoadedProjectWithCodeAnalysis> LoadAsync()
        {
            throw new NotImplementedException();
        }
    }
}
