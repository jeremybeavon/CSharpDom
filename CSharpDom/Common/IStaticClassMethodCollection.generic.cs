using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStaticClassMethodCollection<TMethod, TExtensionMethod> :
        IStaticClassMethodCollection,
        IReadOnlyCollection<TMethod>,
        IHasExtensionMethods<TExtensionMethod>
        where TMethod : IStaticClassMethod
        where TExtensionMethod : IExtensionMethod
    {
    }
}
