using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasAbstractProperties<TProperty>
    {
        IReadOnlyCollection<TProperty> AbstractProperties { get; }
    }
}
