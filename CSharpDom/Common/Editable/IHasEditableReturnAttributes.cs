using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableReturnAttributes<TAttribute> : IHasReturnAttributes<TAttribute>
    {
        new ICollection<TAttribute> ReturnAttributes { get; set; }
    }
}