using CSharpDom.BaseClasses.Editable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
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
        private readonly ChildNodeList<ProjectWithCodeAnalysis, Project, DocumentWithCodeAnalysis, Document> documents;
        private List<LoadedDocumentWithCodeAnalysis> loadedDocuments;
        private LoadedProjectWithCodeAnalysis loadedProject;

        internal ProjectWithCodeAnalysis()
        {
            node = new Node<ProjectWithCodeAnalysis, Project>(this);
            documents = new ChildNodeList<ProjectWithCodeAnalysis, Project, DocumentWithCodeAnalysis, Document>(
                node,
                new DocumentSyntaxList(node),
                () => new DocumentWithCodeAnalysis());
        }

        public override ICollection<DocumentWithCodeAnalysis> Documents
        {
            get { return documents; }
            set { throw new NotSupportedException(); }
        }

        public override SolutionWithCodeAnalysis Solution
        {
            get { return node.GetParent<SolutionWithCodeAnalysis>(); }
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

            ConcurrentBag<Task<LoadedDocumentWithCodeAnalysis>> tasks =
                new ConcurrentBag<Task<LoadedDocumentWithCodeAnalysis>>();
            Parallel.ForEach(documents, document => tasks.Add(document.LoadAsync()));
            loadedDocuments = new List<LoadedDocumentWithCodeAnalysis>(await Task.WhenAll(tasks));
            loadedProject = new LoadedProjectWithCodeAnalysis(this, loadedDocuments);
            return loadedProject;
        }

        public void Lock()
        {
            node.IsLocked = true;
            documents.IsLocked = true;
        }

        public void Unlock()
        {
            node.IsLocked = true;
            documents.IsLocked = true;
        }

        public static async Task<ProjectWithCodeAnalysis> OpenAsync(string fileName)
        {
            MSBuildWorkspace workspace = CodeAnalysisWorkspace.Create();
            return new SolutionWithCodeAnalysis(
                workspace,
                (await workspace.OpenProjectAsync(fileName)).Solution).Projects.First();
        }
    }
}
