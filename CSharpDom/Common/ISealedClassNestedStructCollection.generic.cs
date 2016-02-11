using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassNestedStructCollection<TStruct, TPartialStruct> :
        ISealedClassNestedStructCollection,
        INestedStructCollection<TStruct, TPartialStruct>
        where TStruct : ISealedClassNestedStruct
        where TPartialStruct : IPartialStruct
    {
    }
}
