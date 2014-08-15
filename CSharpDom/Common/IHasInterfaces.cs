using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasInterfaces<TInterface>
    {
        IReadOnlyCollection<TInterface> Interfaces { get; }
    }
}
