using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class SolutionNodeWithLinqExpressions : SolutionNodeWithReflection, ISolutionWithLinqExpressions
    {
        public SolutionNodeWithLinqExpressions(Solution solution, IAssemblyLoader assemblyLoader)
            : base(solution, new LinqExpressionNodeFactory(assemblyLoader))
        {
        }

        public ISolutionWithReflection Reflection
        {
            get { return this; }
        }

        IReadOnlyCollection<IProjectWithLinqExpressions> ISolution<IProjectWithLinqExpressions>.Projects
        {
            get { return new ReadOnlyNodeCollection<IProjectWithLinqExpressions, ProjectNode>(Projects); }
        }

        public Task AcceptAsync(ILinqExpressionsVisitor visitor)
        {
            return AcceptAsync(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
