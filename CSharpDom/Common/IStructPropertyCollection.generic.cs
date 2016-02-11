using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        IStructPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : IStructProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
