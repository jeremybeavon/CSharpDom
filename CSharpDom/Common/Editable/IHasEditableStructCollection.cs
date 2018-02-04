using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStructCollection<TStructCollection> : IHasStructCollection<TStructCollection>
    {
        new TStructCollection Structs { get; set; }
    }
}