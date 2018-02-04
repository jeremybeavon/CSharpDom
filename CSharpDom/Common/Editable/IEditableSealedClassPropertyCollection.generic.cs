using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> :
        IEditableSealedClassPropertyCollection,
        ICollection<TProperty>,
        IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty>,
        ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableSealedClassProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}