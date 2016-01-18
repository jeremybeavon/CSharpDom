using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.CodeAnalysis.WithSyntax;
using CSharpDom.CodeAnalysis.WithSyntax.Internal;
using CSharpDom.Common;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols.Internal
{
    internal class SolutionNodeWithSymbols : SolutionNodeWithSyntax, ISolutionWithSymbols
    {
        public SolutionNodeWithSymbols(Solution solution)
            : base(solution, new SymbolNodeFactory(null))
        {
        }

        protected SolutionNodeWithSymbols(Solution solution, INodeFactory nodeFactory)
            : base(solution, nodeFactory)
        {
        }

        public ISolutionSyntax Syntax
        {
            get { return this; }
        }

        IReadOnlyCollection<IProjectWithSymbols> ISolution<IProjectWithSymbols>.Projects
        {
            get { return new ReadOnlyNodeCollection<IProjectWithSymbols, ProjectNode>(Projects); }
        }

        public Task AcceptAsync(ISymbolsVisitor visitor)
        {
            return AcceptAsync(new SymbolsNodeVisitor(visitor));
        }
    }
}
