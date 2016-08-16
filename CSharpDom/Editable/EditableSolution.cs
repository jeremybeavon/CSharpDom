using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableSolution<TProject> : ISolution<TProject>
        where TProject : IProject
    {
        public virtual IReadOnlyCollection<TProject> Projects { get; set; }

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
