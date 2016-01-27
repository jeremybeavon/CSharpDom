using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAttributes<TAttribute>
    {
        IReadOnlyCollection<TAttribute> Attributes { get; }
    }
}
