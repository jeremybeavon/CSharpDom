using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface INestedStaticClassMethodCollection<TMethod> :
        INestedStaticClassMethodCollection,
        IReadOnlyCollection<TMethod>
        where TMethod : IStaticClassMethod
    {
    }
}
