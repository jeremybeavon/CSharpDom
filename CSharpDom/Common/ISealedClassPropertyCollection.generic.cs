using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        ISealedClassPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : ISealedClassProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
