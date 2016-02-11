using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructNestedStructCollection<TStruct, TPartialStruct> :
        IStructNestedStructCollection,
        INestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IStructNestedStruct
        where TPartialStruct : IPartialStruct
    {
    }
}
