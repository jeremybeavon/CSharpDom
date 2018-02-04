using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableFields<TField> : IHasFields<TField>
    {
        new ICollection<TField> Fields { get; set; }
    }
}