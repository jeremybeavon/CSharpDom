using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasReturnAttributes<TAttribute>
    {
        IReadOnlyCollection<TAttribute> ReturnAttributes { get; }
    }
}
