using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableFieldAttributes<TAttribute> : IHasFieldAttributes<TAttribute>
    {
        new ICollection<TAttribute> FieldAttributes { get; set; }
    }
}