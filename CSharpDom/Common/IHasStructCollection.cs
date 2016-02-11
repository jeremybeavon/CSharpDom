using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasStructCollection<TStructCollection>
    {
        TStructCollection Structs { get; }
    }
}
