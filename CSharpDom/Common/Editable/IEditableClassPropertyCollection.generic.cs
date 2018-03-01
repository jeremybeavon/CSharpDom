using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> :
        IEditableClassPropertyCollection,
        ICollection<TProperty>,
        IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty>,
        IClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableClassProperty
        where TAutoProperty : IEditableClassAutoProperty
        where TLambdaProperty : IEditableClassLambdaProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}