using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassNestedStructCollection<TStruct, TPartialStruct> :
        IClassNestedStructCollection,
        INestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IClassNestedStruct
        where TPartialStruct : IClassNestedPartialStruct
    {
    }
}
