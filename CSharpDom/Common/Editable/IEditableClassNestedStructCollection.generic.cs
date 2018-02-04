using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassNestedStructCollection<TStruct, TPartialStruct> :
        IEditableClassNestedStructCollection,
        IEditableNestedStructCollection<TStruct, TPartialStruct>,
        IClassNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IEditableClassNestedStruct
        where TPartialStruct : IEditableClassNestedPartialStruct
    {
    }
}