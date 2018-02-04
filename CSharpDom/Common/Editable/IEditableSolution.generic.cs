using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSolution<TProject> : IEditableSolution, ISolution<TProject>
        where TProject : IEditableProject
    {
        new ICollection<TProject> Projects { get; set; }
    }
}