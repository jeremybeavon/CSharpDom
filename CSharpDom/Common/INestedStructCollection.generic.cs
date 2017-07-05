using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INestedStructCollection<TStruct, TPartialStruct> :
        INestedStructCollection,
        IReadOnlyCollection<TStruct>,
        IHasPartialStructs<TPartialStruct>
        where TStruct : INestedStruct
        where TPartialStruct : INestedPartialStruct
    {
    }
}
