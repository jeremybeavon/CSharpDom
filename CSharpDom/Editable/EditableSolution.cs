using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableSolution<TProject> : ISolution<TProject>
        where TProject : IProject
    {
        public abstract ICollection<TProject> Projects { get; set; }

        IReadOnlyCollection<TProject> ISolution<TProject>.Projects
        {
            get { return new ReadOnlyCollectionWrapper<TProject>(Projects); }
        }

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
