using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> :
        IEditableAbstractClassPropertyCollection,
        ICollection<TProperty>,
        IHasEditableAbstractProperties<TAbstractProperty>,
        IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty>,
        IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableClassProperty
        where TAbstractProperty : IEditableAbstractProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}