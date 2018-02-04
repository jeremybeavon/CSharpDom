using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditablePartialStructs<TPartialStruct> : IHasPartialStructs<TPartialStruct>
    {
        new ICollection<TPartialStruct> PartialStructs { get; set; }
    }
}