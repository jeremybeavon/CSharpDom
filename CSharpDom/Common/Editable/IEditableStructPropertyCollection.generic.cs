using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableStructPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        IEditableStructPropertyCollection,
        ICollection<TProperty>,
        IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty>,
        IStructPropertyCollection<TProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableStructProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}