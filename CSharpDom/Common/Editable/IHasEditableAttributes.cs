using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableAttributes<TAttribute> : IHasAttributes<TAttribute>
    {
        new ICollection<TAttribute> Attributes { get; set; }
    }
}