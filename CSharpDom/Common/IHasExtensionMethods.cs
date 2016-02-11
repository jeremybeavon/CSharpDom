using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasExtensionMethods<TExtensionMethod>
    {
        IReadOnlyCollection<TExtensionMethod> ExtensionMethods { get; }
    }
}
