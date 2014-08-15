using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom
{
    internal abstract class DocumentNode : TypeContainer, IHasProject<ProjectNode>
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
    }
}
