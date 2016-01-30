using CSharpDom.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Serialization
{
    public sealed class Solution : ISolution<Project>
    {
        public Solution()
        {
            Projects = new List<Project>();
        }

        public List<Project> Projects { get; set; }

        IReadOnlyCollection<Project> ISolution<Project>.Projects
        {
            get { return Projects; }
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
