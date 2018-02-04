using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasImplementedInterfaces<TInterfaceReference>
    {
        IReadOnlyCollection<TInterfaceReference> ImplementedInterfaces { get; }
    }
}
