using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSyntax.Internal
{
    internal class SolutionNodeWithSyntax : SolutionNode, ISolutionSyntax
    {
        public SolutionNodeWithSyntax(Solution solution)
            : base(solution, SyntaxNodeFactory.Instance)
        {
        }

        protected SolutionNodeWithSyntax(Solution solution, INodeFactory nodeFactory)
            : base(solution, nodeFactory)
        {
        }

        IReadOnlyCollection<IProjectSyntax> ISolution<IProjectSyntax>.Projects
        {
            get { return new ReadOnlyNodeCollection<IProjectSyntax, ProjectNode>(Projects); }
        }

        public Task AcceptAsync(ISyntaxVisitor visitor)
        {
            return AcceptAsync(new SyntaxNodeVisitor(visitor));
        }
    }
}
