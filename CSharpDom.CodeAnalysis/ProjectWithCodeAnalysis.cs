using CSharpDom.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ProjectWithCodeAnalysis :
        EditableProject<SolutionWithCodeAnalysis, DocumentWithCodeAnalysis, LoadedProjectWithCodeAnalysis>,
        IHasSyntax<Project>,
        IHasNode<Project>
    {
        private readonly Node<ProjectWithCodeAnalysis, Project> node;
        private readonly ImmutableListWrapper<ProjectWithCodeAnalysis, Project, DocumentWithCodeAnalysis, Document> documents;
        private List<LoadedDocumentWithCodeAnalysis> loadedDocuments;
        private LoadedProjectWithCodeAnalysis loadedProject;

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

        public override async Task<LoadedProjectWithCodeAnalysis> LoadAsync()
        {
            if (loadedProject != null)
            {
                return loadedProject;
            }

            loadedDocuments = new List<LoadedDocumentWithCodeAnalysis>(
                await Task.WhenAll(documents.Select(document => document.LoadAsync())));
            loadedProject = new LoadedProjectWithCodeAnalysis(this, loadedDocuments);
            return loadedProject;
        }

        public static async Task<ProjectWithCodeAnalysis> OpenAsync(string fileName)
        {
            return new ProjectWithCodeAnalysis()
            {
                Syntax = await MSBuildWorkspace.Create().OpenProjectAsync(fileName)
            };
        }
    }
}
