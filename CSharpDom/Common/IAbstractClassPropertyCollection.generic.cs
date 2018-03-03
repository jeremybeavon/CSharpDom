using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface IAbstractClassPropertyCollection<
        TProperty, 
        TAutoProperty,
        TLambdaProperty,
        TAbstractProperty,
        TExplicitInterfaceProperty> :
        IAbstractClassPropertyCollection,
        IClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>,
        IHasAbstractProperties<TAbstractProperty>
        where TProperty : IClassProperty
        where TAutoProperty : IClassAutoProperty
        where TLambdaProperty : IClassLambdaProperty
        where TAbstractProperty : IAbstractProperty
        where TExplicitInterfaceProperty : IExplicitInterfaceProperty
    {
    }
}
