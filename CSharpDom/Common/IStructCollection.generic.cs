using CSharpDom.Common.Partial;
using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructCollection<TStruct, TPartialStruct> :
        IStructCollection,
        IReadOnlyCollection<TStruct>,
        IHasPartialStructs<TPartialStruct>
        where TStruct : IStruct
        where TPartialStruct : IPartialStruct
    {
    }
}
