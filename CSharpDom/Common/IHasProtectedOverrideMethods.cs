using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasProtectedOverrideMethods<TMethod>
    {
        IReadOnlyCollection<TMethod> ProtectedOverrideMethods { get; }
    }
}
