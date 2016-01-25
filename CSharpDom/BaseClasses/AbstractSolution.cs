using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSolution<TProject> : ISolution<TProject>
        where TProject : IProject
    {
        public abstract IReadOnlyCollection<TProject> Projects { get; }

        public Task AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitSolutionAsync(this);
        }

        public Task AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitSolutionChildrenAsync(this, visitor);
        }
    }
}
