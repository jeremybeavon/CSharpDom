using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStaticClassNestedStructCollection<TStruct, TPartialStruct> :
        IEditableStaticClassNestedStructCollection,
        IEditableNestedStructCollection<TStruct, TPartialStruct>,
        IStaticClassNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IEditableStaticClassNestedStruct
        where TPartialStruct : IEditableStaticClassNestedPartialStruct
    {
    }
}