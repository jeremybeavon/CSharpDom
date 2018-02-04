using CSharpDom.Common.Partial;

namespace CSharpDom.Common.Editable.Partial
{
    public interface IEditableStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> :
        IEditableStaticClassNestedStaticPartialClass,
        IEditableStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>,
        IStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IEditableAttributeGroup
        where TDeclaringType : IEditableStaticType
        where TGenericParameter : IEditableGenericParameterDeclaration
        where TEventCollection : IEditableStaticClassEventCollection
        where TProperty : IEditableStaticClassProperty
        where TMethodCollection : IEditableNestedStaticPartialClassMethodCollection
        where TFieldCollection : IEditableStaticClassFieldCollection
        where TNestedClassCollection : IEditableStaticClassNestedClassCollection
        where TNestedDelegate : IEditableStaticClassNestedDelegate
        where TNestedEnum : IEditableStaticClassNestedEnum
        where TNestedInterface : IEditableStaticClassNestedInterface
        where TNestedStructCollection : IEditableStaticClassNestedStructCollection
        where TStaticConstructor : IEditableStaticConstructor
    {
    }
}