using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasStaticClasses<TStaticClass>
    {
        IReadOnlyCollection<TStaticClass> StaticClasses { get; }
    }
}
