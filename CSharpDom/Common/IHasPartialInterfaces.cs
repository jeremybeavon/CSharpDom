using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasPartialInterfaces<TPartialInterface>
    {
        IReadOnlyCollection<TPartialInterface> PartialInterfaces { get; }
    }
}
