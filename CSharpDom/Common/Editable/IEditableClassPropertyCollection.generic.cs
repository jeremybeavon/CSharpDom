using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableClassPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        IEditableClassPropertyCollection,
        ICollection<TProperty>,
        IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty>,
        IClassPropertyCollection<TProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableClassProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}