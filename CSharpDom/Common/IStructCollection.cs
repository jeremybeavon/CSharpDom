using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructCollection<TStruct, TPartialStruct>
    {
        IReadOnlyCollection<TStruct> Structs { get; }

        IReadOnlyCollection<TPartialStruct> PartialStructs { get; }
    }
}
