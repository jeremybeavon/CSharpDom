using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
    {
        IReadOnlyCollection<TExplicitInterfaceProperty> ExplicitInterfaceProperties { get; }
    }
}
