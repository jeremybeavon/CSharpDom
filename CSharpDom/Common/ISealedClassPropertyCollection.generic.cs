using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> :
        ISealedClassPropertyCollection,
        IReadOnlyCollection<TProperty>,
        IHasAutoProperties<TAutoProperty>,
        IHasLambdaProperties<TLambdaProperty>,
        IHasExplicitInterfaceProperties<TExplicitInterfaceProperty>
        where TProperty : ISealedClassProperty
        where TAutoProperty : ISealedClassAutoProperty
        where TLambdaProperty : ISealedClassLambdaProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
