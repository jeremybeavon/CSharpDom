namespace CSharpDom.Common.Partial
{
    public interface IClassNestedPartialStruct<TAttributeGroup,
        TDeclaringType,
        TGenericParameter,
        TInterfaceReference,
        TEventCollection,
        TPropertyCollection,
        TIndexerCollection,
        TMethodCollection,
        TFieldCollection,
        TConstructor,
        TOperatorOverload,
        TConversionOperator,
        TNestedClassCollection,
        TNestedDelegate,
        TNestedEnum,
        TNestedInterface,
        TNestedStructCollection,
        TStaticConstructor> :
        IClassNestedStruct,
        IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TGenericParameter : IGenericParameterDeclaration
        where TInterfaceReference : IInterfaceReference
        where TEventCollection : IStructEventCollection
        where TPropertyCollection : IStructPropertyCollection
        where TIndexerCollection : IStructIndexerCollection
        where TMethodCollection : IPartialStructMethodCollection
        where TFieldCollection : IStructFieldCollection
        where TConstructor : IStructConstructor
        where TOperatorOverload : IOperatorOverload
        where TConversionOperator : IConversionOperator
        where TNestedClassCollection : IStructNestedClassCollection
        where TNestedDelegate : IStructNestedDelegate
        where TNestedEnum : IStructNestedEnum
        where TNestedInterface : IStructNestedInterface
        where TNestedStructCollection : IStructNestedStructCollection
        where TStaticConstructor : IStaticConstructor
    {
    }
}
