using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassPropertyCollection<TProperty, TProtectedOverrideProperty, TExplicitInterfaceProperty> :
        ISealedClassPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasProtectedOverrideProperties<TProtectedOverrideProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : ISealedClassProperty
        where TProtectedOverrideProperty : IProtectedOverrideProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
