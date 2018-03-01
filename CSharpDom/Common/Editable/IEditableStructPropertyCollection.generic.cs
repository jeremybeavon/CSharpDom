using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TExplicitInterfaceProperty> :
        IEditableStructPropertyCollection,
        ICollection<TProperty>,
        IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty>,
        IStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableStructProperty
        where TAutoProperty : IEditableStructAutoProperty
        where TLambdaProperty : IEditableStructLambdaProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}