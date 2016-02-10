using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        IClassPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
