using System;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal abstract class DocumentNode : AbstractNode, IHasProject<ProjectNode>
    {
        protected DocumentNode(Document document, ProjectNode project)
        {
            Document = document;
            Project = project;
        }

        public string FullFilePath
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ProjectNode Project { get; private set; }

        public SolutionNode Solution
        {
            get { return Project.Solution; }
        }

        public Document Document { get; private set; }

        public override string ToString()
        {
            return Document.ToString();
        }

        public Task<LoadedDocumentNode> LoadAsync()
        {
            return null;
        }
    }
}
