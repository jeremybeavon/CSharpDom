using CSharpDom.Common.Editable.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructCollection<TStruct, TPartialStruct> :
        IEditableStructCollection,
        ICollection<TStruct>,
        IHasEditablePartialStructs<TPartialStruct>,
        IStructCollection<TStruct, TPartialStruct>
        where TStruct : IEditableStruct
        where TPartialStruct : IEditablePartialStruct
    {
    }
}