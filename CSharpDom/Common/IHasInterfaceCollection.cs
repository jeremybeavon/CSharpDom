using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasInterfaceCollection<TInterfaceCollection>
    {
        TInterfaceCollection Interfaces { get; }
    }
}
