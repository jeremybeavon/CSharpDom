using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableConstants<TConstant> : IHasConstants<TConstant>
    {
        new ICollection<TConstant> Constants { get; set; }
    }
}