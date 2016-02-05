using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAbstractMethods<TMethod>
    {
        IReadOnlyCollection<TMethod> AbstractMethods { get; }
    }
}
