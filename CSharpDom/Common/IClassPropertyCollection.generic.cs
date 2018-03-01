using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> :
        IClassPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasAutoProperties<TAutoProperty>,
        IHasLambdaProperties<TLambdaProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : IClassProperty
        where TAutoProperty : IClassAutoProperty
        where TLambdaProperty : IClassLambdaProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
