using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasOperatorOverloads<TOperatorOverload>
    {
        IReadOnlyCollection<TOperatorOverload> OperatorOverloads { get; }
    }
}
