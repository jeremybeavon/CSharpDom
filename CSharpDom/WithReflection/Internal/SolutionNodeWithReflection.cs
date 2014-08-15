using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithReflection.Internal
{
    internal class SolutionNodeWithReflection : SolutionNodeWithSymbols, ISolutionWithReflection
    {
        public SolutionNodeWithReflection(Solution solution, IAssemblyLoader assemblyLoader)
            : base(solution, new ReflectionNodeFactory(assemblyLoader))
        {
        }

        protected SolutionNodeWithReflection(Solution solution, INodeFactory nodeFactory)
            : base(solution, nodeFactory)
        {
        }

        public ISolutionWithSymbols Symbols
        {
            get { return this; }
        }

        IReadOnlyCollection<IProjectWithReflection> ISolution<IProjectWithReflection>.Projects
        {
            get { return new ReadOnlyNodeCollection<IProjectWithReflection, ProjectNode>(Projects); }
        }

        public Task AcceptAsync(IReflectionVisitor visitor)
        {
            return AcceptAsync(new ReflectionNodeVisitor(visitor));
        }
    }
}
