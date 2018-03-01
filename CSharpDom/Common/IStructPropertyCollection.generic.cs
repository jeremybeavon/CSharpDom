using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> :
        IStructPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasAutoProperties<TAutoProperty>,
        IHasLambdaProperties<TLambdaProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : IStructProperty
        where TAutoProperty : IStructAutoProperty
        where TLambdaProperty : IStructLambdaProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
