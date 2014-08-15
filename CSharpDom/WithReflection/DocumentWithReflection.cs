using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection
{
    public sealed class DocumentWithReflection
    {
        private readonly IDocumentWithReflection document;

        public DocumentWithReflection(IDocumentWithReflection document)
        {
            this.document = document;
        }

        public Document Document
        {
            get { return document.Document; }
        }

        public string FullFilePath
        {
            get { return document.FullFilePath; }
        }

        public ProjectWithReflection Project
        {
            get { return ProjectWithReflection.GetProject(document.Project); }
        }

        public SolutionWithReflection Solution
        {
            get { return SolutionWithReflection.GetSolution(document.Solution); }
        }

        public IDocumentWithReflection AsInterface()
        {
            return document;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            document.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return document.ToString();
        }
    }
}
