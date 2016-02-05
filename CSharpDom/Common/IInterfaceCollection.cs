using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IInterfaceCollection<TInterface, TPartialInterface>
    {
        IReadOnlyCollection<TInterface> Interfaces { get; }

        IReadOnlyCollection<TPartialInterface> PartialInterfaces { get; }
    }
}
