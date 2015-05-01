using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class DocumentNodeWithLinqExpressions : DocumentNodeWithReflection, IDocumentWithLinqExpressions
    {
        public DocumentNodeWithLinqExpressions(Document document, ProjectNode project)
            : base(document, project)
        {
        }

        public IDocumentWithReflection Reflection
        {
            get { return this; }
        }

        IProjectWithLinqExpressions IHasProject<IProjectWithLinqExpressions>.Project
        {
            get { return (IProjectWithLinqExpressions)Project; }
        }

        ISolutionWithLinqExpressions IHasSolution<ISolutionWithLinqExpressions>.Solution
        {
            get { return (ISolutionWithLinqExpressions)Solution; }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
