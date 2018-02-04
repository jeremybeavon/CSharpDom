using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStructs<TStruct> : IHasStructs<TStruct>
    {
        new ICollection<TStruct> Structs { get; set; }
    }
}