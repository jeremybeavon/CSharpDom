using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStaticClassNestedStructCollection<TStruct, TPartialStruct> :
        IStaticClassNestedStructCollection,
        INestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IStaticClassNestedStruct
        where TPartialStruct : IPartialStruct
    {
    }
}
