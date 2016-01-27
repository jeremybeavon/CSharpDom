using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasProperties<TProperty>
    {
        IReadOnlyCollection<TProperty> Properties { get; }
    }
}
