using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableNestedStructCollection<TStruct, TPartialStruct> :
        IEditableNestedStructCollection,
        ICollection<TStruct>,
        IHasEditablePartialStructs<TPartialStruct>,
        INestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IEditableNestedStruct
        where TPartialStruct : IEditableNestedPartialStruct
    {
    }
}