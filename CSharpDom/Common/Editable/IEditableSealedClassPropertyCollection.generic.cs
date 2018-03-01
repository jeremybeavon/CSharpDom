using System.Collections.Generic;

namespace CSharpDom.Common.Editable
{
    public interface IEditableSealedClassPropertyCollection<
        TProperty,
        TAutoProperty,
        TLambdaProperty,
        TExplicitInterfaceProperty> :
        IEditableSealedClassPropertyCollection,
        ICollection<TProperty>,
        IHasEditableExplicitInterfaceProperties<TExplicitInterfaceProperty>,
        ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
        where TProperty : IEditableSealedClassProperty
        where TAutoProperty : IEditableSealedClassAutoProperty
        where TLambdaProperty : IEditableSealedClassLambdaProperty
        where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty
    {
    }
}