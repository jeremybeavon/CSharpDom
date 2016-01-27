using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasFieldAttributes<TAttribute>
    {
        IReadOnlyCollection<TAttribute> FieldAttributes { get; }
    }
}
