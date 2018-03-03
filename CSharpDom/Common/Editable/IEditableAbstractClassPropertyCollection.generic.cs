using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TAbstractProperty,
        TExplicitInterfaceProperty> :
        IEditableAbstractClassPropertyCollection,
        IEditableClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>,
        IHasEditableAbstractProperties<TAbstractProperty>,
        IAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableClassProperty
        where TAutoProperty : IEditableClassAutoProperty
        where TLambdaProperty : IEditableClassLambdaProperty
        where TAbstractProperty : IEditableAbstractProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}