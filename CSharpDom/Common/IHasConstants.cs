using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasConstants<TConstant>
    {
        IReadOnlyCollection<TConstant> Constants { get; }
    }
}
