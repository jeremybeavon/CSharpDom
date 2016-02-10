using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> :
        IAbstractClassPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasAbstractProperties<TAbstractProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TAbstractProperty : IAbstractProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
