using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasStructs<TStruct>
    {
        IReadOnlyCollection<TStruct> Structs { get; }
    }
}
