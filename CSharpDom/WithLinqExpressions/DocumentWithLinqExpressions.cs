using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class DocumentWithLinqExpressions
    {
        private readonly IDocumentWithLinqExpressions document;

        public DocumentWithLinqExpressions(IDocumentWithLinqExpressions document)
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

        public ProjectWithLinqExpressions Project
        {
            get { return ProjectWithLinqExpressions.GetProject(document.Project); }
        }

        public SolutionWithLinqExpressions Solution
        {
            get { return SolutionWithLinqExpressions.GetSolution(document.Solution); }
        }

        public IDocumentWithLinqExpressions AsInterface()
        {
            return document;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            document.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return document.ToString();
        }
    }
}
