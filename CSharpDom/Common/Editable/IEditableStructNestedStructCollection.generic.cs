using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructNestedStructCollection<TStruct, TPartialStruct> :
        IEditableStructNestedStructCollection,
        IEditableNestedStructCollection<TStruct, TPartialStruct>,
        IStructNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IEditableStructNestedStruct
        where TPartialStruct : IEditableStructNestedPartialStruct
    {
    }
}