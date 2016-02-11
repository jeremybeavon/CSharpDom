using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasPartialStructs<TPartialStruct>
    {
        IReadOnlyCollection<TPartialStruct> PartialStructs { get; }
    }
}
