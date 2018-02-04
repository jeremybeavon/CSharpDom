using CSharpDom.Common.Editable.Expressions;
using CSharpDom.Common.Editable.Partial;
using System.Threading.Tasks;

namespace CSharpDom.Common.Editable
{
    public interface IEditableVisitor
    {
        void Visit(IVisitable<IEditableVisitor> node);

        void VisitAbstractAccessor<TAttributeGroup>(IEditableAbstractAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IEditableAttributeGroup;

        void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IEditableAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IEditableClassEvent
            where TEventProperty : IEditableClassEventProperty
            where TAbstractEvent : IEditableAbstractEvent
            where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent;

        void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IEditableAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IEditableClassIndexer
            where TAbstractIndexer : IEditableAbstractIndexer
            where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer;

        void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IEditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IEditableClassMethod
            where TAbstractMethod : IEditableAbstractMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod;

        void VisitAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IEditableAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IEditableClassMethod
            where TAbstractMethod : IEditableAbstractMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
            where TPartialMethodDefinition : IEditablePartialMethodDefinition
            where TPartialMethodImplementation : IEditablePartialMethodImplementation;

        void VisitAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IEditableAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IEditableClassProperty
            where TAbstractProperty : IEditableAbstractProperty
            where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty;

        void VisitAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEditableAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableAbstractType
            where TDelegateReference : IEditableDelegateReference;

        void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IEditableAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableAbstractType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableIndexerParameter
            where TAccessor : IEditableAbstractAccessor;

        void VisitAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IEditableAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableAbstractType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter;

        void VisitAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IEditableAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableAbstractType
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableAbstractAccessor;

        void VisitAccessor<TAttributeGroup, TMethodBody>(IEditableAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IEditableAttributeGroup
            where TMethodBody : IEditableMethodBody;

        Task VisitAsync(IAsyncVisitable<IEditableVisitor> node);

        void VisitArrayTypeReference<TTypeReference>(IEditableArrayTypeReference<TTypeReference> arrayTypeReference)
            where TTypeReference : IEditableTypeReference;

        void VisitAttributeGroup<TAttribute>(IEditableAttributeGroup<TAttribute> attributes)
            where TAttribute : IEditableAttribute;

        void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IEditableAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
            where TClassReference : IEditableClassReference
            where TUnnamedAttributeValue : IEditableUnnamedAttributeValue
            where TNamedAttributeValue : IEditableNamedAttributeValue;

        void VisitBuiltInTypeReference(IEditableBuiltInTypeReference builtInTypeReference);

        void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditableClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>(
            IEditablePartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> classes)
            where TClass : IEditableClassType
            where TAbstractClass : IEditableAbstractType
            where TSealedClass : IEditableSealedType
            where TStaticClass : IEditableStaticType;

        void VisitPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditablePartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditablePartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassAccessor<TAttributeGroup, TMethodBody>(IEditableClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IEditableAttributeGroup
            where TMethodBody : IEditableMethodBody;

        void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IEditableClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TParameter : IEditableConstructorParameter
            where TMethodBody : IEditableMethodBody;

        void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEditableClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TDelegateReference : IEditableDelegateReference;

        void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEditableClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TDelegateReference : IEditableDelegateReference
            where TMethodBody : IEditableMethodBody;

        void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IEditableClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TTypeReference : IEditableTypeReference
            where TField : IEditableField;

        void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IEditableClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableIndexerParameter
            where TAccessor : IEditableClassAccessor;

        void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IEditableClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>(
            IEditablePartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TParameter : IEditableMethodParameter;

        void VisitPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(
            IEditablePartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditableClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditablePartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IEditableClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableDelegateParameter;

        void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IEditableClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TNestedEnumMember : IEditableNestedEnumMember;

        void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IEditableClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEvent : IEditableInterfaceEvent
            where TProperty : IEditableInterfaceProperty
            where TIndexer : IEditableInterfaceIndexer
            where TMethod : IEditableInterfaceMethod;

        void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditableStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditablePartialStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IEditableClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableClassAccessor;

        void VisitClassReference<TTypeReference>(IEditableClassReference<TTypeReference> classReference)
            where TTypeReference : IEditableTypeReference;

        void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IEditableConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableOperatorParameter
            where TMethodBody : IEditableMethodBody;

        void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IEditableDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableDelegateParameter;

        void VisitDelegateReference<TTypeReference>(IEditableDelegateReference<TTypeReference> delegateReference)
            where TTypeReference : IEditableTypeReference;

        void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IEditableDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TMethodBody : IEditableMethodBody;

        Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(
            IEditableDocument<TProject, TSolution, TLoadedDocument> document)
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TLoadedDocument : IEditableLoadedDocument;

        void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEditableEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TEnumMember : IEditableEnumMember;

        void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEditableEnumMember<TAttributeGroup, TDeclaringType> enumMember)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableEnum;

        void VisitEnumReference(IEditableEnumReference enumReference);

        void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IEditableExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TInterfaceReference : IEditableInterfaceReference
            where TDelegateReference : IEditableDelegateReference
            where TMethodBody : IEditableMethodBody;

        void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IEditableExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TInterfaceReference : IEditableInterfaceReference
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableIndexerParameter
            where TAccessor : IEditableAccessor;

        void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IEditableExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TInterfaceReference : IEditableInterfaceReference
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IEditableExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TInterfaceReference : IEditableInterfaceReference
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableAccessor;

        void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IEditableGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
            where TClassReference : IEditableClassReference
            where TGenericParameterReference : IEditableGenericParameterReference
            where TInterfaceReference : IEditableInterfaceReference
            where TAttributeGroup : IEditableAttributeGroup;

        void VisitGenericParameterReference(IEditableGenericParameterReference genericParameterReference);

        void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IEditableInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEvent : IEditableInterfaceEvent
            where TProperty : IEditableInterfaceProperty
            where TIndexer : IEditableInterfaceIndexer
            where TMethod : IEditableInterfaceMethod;

        void VisitInterfaceAccessor<TAttributeGroup>(IEditableInterfaceAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IEditableAttributeGroup;

        void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEditableInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableInterfaceType
            where TDelegateReference : IEditableDelegateReference;

        void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IEditableInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableInterfaceType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableIndexerParameter
            where TAccessor : IEditableInterfaceAccessor;

        void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IEditableInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableInterfaceType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter;

        void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IEditableInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableInterfaceType
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableInterfaceAccessor;

        void VisitInterfaceReference<TTypeReference>(IEditableInterfaceReference<TTypeReference> interfaceReference)
            where TTypeReference : IEditableTypeReference;

        void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            IEditableLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> loadedDocument)
            where TSolution : IEditableSolution
            where TProject : IEditableProject
            where TDocument : IEditableDocument
            where TUsingDirective : IEditableUsingDirective
            where TAttributeGroup : IEditableAttributeGroup
            where TNamespace : IEditableNamespace
            where TClassCollection : IEditableClassCollection
            where TDelegate : IEditableDelegate
            where TEnum : IEditableEnum
            where TInterface : IEditableInterface
            where TStructCollection : IEditableStructCollection;

        void VisitMethodBody<TStatement>(IEditableMethodBody<TStatement> methodBody);

        void VisitNamedAttributeValue<TExpression>(IEditableNamedAttributeValue<TExpression> namedAttributeValue)
            where TExpression : IEditableExpression;

        void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            IEditableNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> @namespace)
            where TUsingDirective : IEditableUsingDirective
            where TNamespace : IEditableNamespace
            where TClassCollection : IEditableClassCollection
            where TDelegate : IEditableDelegate
            where TEnum : IEditableEnum
            where TInterface : IEditableInterface
            where TStructCollection : IEditableStructCollection;

        void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            IEditableNestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableNestedEnum;

        void VisitNestedTypeReference<TTypeReference>(IEditableNestedTypeReference<TTypeReference> nestedTypeReference)
            where TTypeReference : IEditableTypeReference;

        void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IEditableOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableOperatorParameter
            where TMethodBody : IEditableMethodBody;

        void VisitParameter<TAttributeGroup, TTypeReference>(IEditableParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IEditableAttributeGroup
            where TTypeReference : IEditableTypeReference;

        void VisitConstructorParameter<TAttributeGroup, TTypeReference>(
            IEditableConstructorParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IEditableAttributeGroup
            where TTypeReference : IEditableTypeReference;

        void VisitDelegateParameter<TAttributeGroup, TTypeReference>(
            IEditableDelegateParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IEditableAttributeGroup
            where TTypeReference : IEditableTypeReference;

        void VisitExtensionParameter<TAttributeGroup, TTypeReference>(
            IEditableExtensionParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IEditableAttributeGroup
            where TTypeReference : IEditableTypeReference;

        void VisitIndexerParameter<TAttributeGroup, TTypeReference>(
            IEditableIndexerParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IEditableAttributeGroup
            where TTypeReference : IEditableTypeReference;

        void VisitMethodParameter<TAttributeGroup, TTypeReference>(
            IEditableMethodParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IEditableAttributeGroup
            where TTypeReference : IEditableTypeReference;

        void VisitOperatorParameter<TAttributeGroup, TTypeReference>(
            IEditableOperatorParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IEditableAttributeGroup
            where TTypeReference : IEditableTypeReference;

        Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(
            IEditableProject<TSolution, TDocument, TLoadedProject> project)
            where TSolution : IEditableSolution
            where TDocument : IEditableDocument
            where TLoadedProject : IEditableLoadedProject;

        void VisitSealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableSealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitSealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableSealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEditableSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableSealedType
            where TDelegateReference : IEditableDelegateReference;

        void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEditableSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableSealedType
            where TDelegateReference : IEditableDelegateReference
            where TMethodBody : IEditableMethodBody;

        void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IEditableSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableSealedType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableIndexerParameter
            where TAccessor : IEditableClassAccessor;

        void VisitSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IEditableSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableSealedType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IEditableSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableSealedType
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableClassAccessor;

        Task VisitSolutionAsync<TProject>(IEditableSolution<TProject> solution)
            where TProject : IEditableProject;

        void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IEditableStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TMethodBody : IEditableMethodBody;

        void VisitStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TEventCollection : IEditableStaticClassEventCollection
            where TProperty : IEditableStaticClassProperty
            where TMethodCollection : IEditableStaticClassMethodCollection
            where TFieldCollection : IEditableStaticClassFieldCollection
            where TNestedClassCollection : IEditableStaticClassNestedClassCollection
            where TNestedDelegate : IEditableStaticClassNestedDelegate
            where TNestedEnum : IEditableStaticClassNestedEnum
            where TNestedInterface : IEditableStaticClassNestedInterface
            where TNestedStructCollection : IEditableStaticClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TEventCollection : IEditableStaticClassEventCollection
            where TProperty : IEditableStaticClassProperty
            where TMethodCollection : IEditableStaticPartialClassMethodCollection
            where TFieldCollection : IEditableStaticClassFieldCollection
            where TNestedClassCollection : IEditableStaticClassNestedClassCollection
            where TNestedDelegate : IEditableStaticClassNestedDelegate
            where TNestedEnum : IEditableStaticClassNestedEnum
            where TNestedInterface : IEditableStaticClassNestedInterface
            where TNestedStructCollection : IEditableStaticClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(
            IEditableStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IEditableAttributeGroup
            where TMethodBody : IEditableMethodBody;

        void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEditableStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TDelegateReference : IEditableDelegateReference;

        void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEditableStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TDelegateReference : IEditableDelegateReference
            where TMethodBody : IEditableMethodBody;

        void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IEditableStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TTypeReference : IEditableTypeReference
            where TField : IEditableField;

        void VisitStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IEditableStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditableClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditablePartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IEditableStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableDelegateParameter;

        void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IEditableStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TNestedEnumMember : IEditableNestedEnumMember;

        void VisitStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IEditableStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEvent : IEditableInterfaceEvent
            where TProperty : IEditableInterfaceProperty
            where TIndexer : IEditableInterfaceIndexer
            where TMethod : IEditableInterfaceMethod;

        void VisitStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditableStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditablePartialStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IEditableStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableStaticClassAccessor;

        void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditableStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditablePartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
            where TNamespace : IEditableNamespace
            where TDocument : IEditableDocument
            where TProject : IEditableProject
            where TSolution : IEditableSolution
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditablePartialStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStructAccessor<TAttributeGroup, TMethodBody>(IEditableStructAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IEditableAttributeGroup
            where TMethodBody : IEditableMethodBody;

        void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IEditableStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TParameter : IEditableConstructorParameter
            where TMethodBody : IEditableMethodBody;

        void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEditableStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TDelegateReference : IEditableDelegateReference;

        void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEditableStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TDelegateReference : IEditableDelegateReference
            where TMethodBody : IEditableMethodBody;

        void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IEditableStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TTypeReference : IEditableTypeReference
            where TField : IEditableField;

        void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IEditableStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableIndexerParameter
            where TAccessor : IEditableStructAccessor;

        void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IEditableStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditableClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStructNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditablePartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IEditableStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableDelegateParameter;

        void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IEditableStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TNestedEnumMember : IEditableNestedEnumMember;

        void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IEditableStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEvent : IEditableInterfaceEvent
            where TProperty : IEditableInterfaceProperty
            where TIndexer : IEditableInterfaceIndexer
            where TMethod : IEditableInterfaceMethod;

        void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditableStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditablePartialStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IEditableStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableStructAccessor;

        void VisitStructReference<TTypeReference>(IEditableStructReference<TTypeReference> structReference)
            where TTypeReference : IEditableTypeReference;

        void VisitUnnamedAttributeValue<TExpression>(IEditableUnnamedAttributeValue<TExpression> unnamedAttributeValue)
            where TExpression : IEditableExpression;

        void VisitUnspecifiedTypeReference<TTypeReference>(
            IEditableUnspecifiedTypeReference<TTypeReference> unspecificTypeReference)
            where TTypeReference : IEditableTypeReference;

        void VisitUsingDirective(IEditableUsingDirective usingDirective);

        void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IEditableConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TParameter : IEditableConstructorParameter
            where TMethodBody : IEditableMethodBody;

        void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEditableEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableBasicType
            where TDelegateReference : IEditableDelegateReference;

        void VisitEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TDelegateReference : IEditableDelegateReference
            where TMethodBody : IEditableMethodBody;

        void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IEditableIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableBasicType
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableIndexerParameter
            where TAccessor : IEditableAccessor;

        void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IEditableMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableBasicType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableMethodParameter;

        void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditableClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IEditableDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableDelegateParameter;

        void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IEditableNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TParameter : IEditableDelegateParameter;

        void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IEditableNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TNestedEnumMember : IEditableNestedEnumMember;

        void VisitNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IEditableNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEvent : IEditableInterfaceEvent
            where TProperty : IEditableInterfaceProperty
            where TIndexer : IEditableInterfaceIndexer
            where TMethod : IEditableInterfaceMethod;

        void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditableStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitNullableTypeReference<TStructReference>(IEditableNullableTypeReference<TStructReference> reference)
            where TStructReference : IEditableStructReference;

        void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IEditableProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableBasicType
            where TTypeReference : IEditableTypeReference
            where TAccessor : IEditableAccessor;

        void VisitType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableEventCollection
            where TPropertyCollection : IEditablePropertyCollection
            where TIndexerCollection : IEditableIndexerCollection
            where TMethodCollection : IEditableMethodCollection
            where TFieldCollection : IEditableFieldCollection
            where TConstructor : IEditableConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableNestedClassCollection
            where TNestedDelegate : IEditableNestedDelegate
            where TNestedEnum : IEditableNestedEnum
            where TNestedInterface : IEditableNestedInterface
            where TNestedStructCollection : IEditableNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IEditableClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IEditableClass
            where TAbstractClass : IEditableAbstractClass
            where TSealedClass : IEditableSealedClass
            where TStaticClass : IEditableStaticClass
            where TPartialClassCollection : IEditablePartialClassCollection;

        void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IEditableClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> classConstant)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TTypeReference : IEditableTypeReference
            where TConstant : IEditableConstant;

        void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IEditableClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IEditableClassEvent
            where TEventProperty : IEditableClassEventProperty
            where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent;

        void VisitClassFieldCollection<TField, TConstant>(IEditableClassFieldCollection<TField, TConstant> fieldCollection)
            where TField : IEditableClassField
            where TConstant : IEditableClassConstant;

        void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IEditableClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IEditableClassIndexer
            where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer;

        void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IEditableClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IEditableClassMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod;

        void VisitPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IEditablePartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IEditableClassMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
            where TPartialMethodDefinition : IEditablePartialMethodDefinition
            where TPartialMethodImplementation : IEditablePartialMethodImplementation;

        void VisitClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IEditableClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> nestedClass)
            where TClass : IEditableClassNestedClass
            where TAbstractClass : IEditableClassNestedAbstractClass
            where TSealedClass : IEditableClassNestedSealedClass
            where TStaticClass : IEditableClassNestedStaticClass
            where TPartialClassCollection : IEditablePartialClassCollection;

        void VisitClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TEventCollection : IEditableStaticClassEventCollection
            where TProperty : IEditableStaticClassProperty
            where TMethodCollection : IEditableNestedStaticClassMethodCollection
            where TFieldCollection : IEditableStaticClassFieldCollection
            where TNestedClassCollection : IEditableStaticClassNestedClassCollection
            where TNestedDelegate : IEditableStaticClassNestedDelegate
            where TNestedEnum : IEditableStaticClassNestedEnum
            where TNestedInterface : IEditableStaticClassNestedInterface
            where TNestedStructCollection : IEditableStaticClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableClassType
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
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TEventCollection : IEditableStaticClassEventCollection
            where TProperty : IEditableStaticClassProperty
            where TMethodCollection : IEditableNestedStaticClassMethodCollection
            where TFieldCollection : IEditableStaticClassFieldCollection
            where TNestedClassCollection : IEditableStaticClassNestedClassCollection
            where TNestedDelegate : IEditableStaticClassNestedDelegate
            where TNestedEnum : IEditableStaticClassNestedEnum
            where TNestedInterface : IEditableStaticClassNestedInterface
            where TNestedStructCollection : IEditableStaticClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
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
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitClassNestedStructCollection<TStruct, TPartialStruct>(
            IEditableClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IEditableClassNestedStruct
            where TPartialStruct : IEditableClassNestedPartialStruct;

        void VisitClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IEditableClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IEditableClassProperty
            where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty;

        void VisitClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableClassEventCollection
            where TPropertyCollection : IEditableClassPropertyCollection
            where TIndexerCollection : IEditableClassIndexerCollection
            where TMethodCollection : IEditableClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitConstant<TExpression>(IEditableConstant<TExpression> constant)
            where TExpression : IEditableExpression;

        void VisitConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IEditableConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constantGroup)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TTypeReference : IEditableTypeReference
            where TConstant : IEditableConstant;

        void VisitField<TExpression>(IEditableField<TExpression> field)
            where TExpression : IEditableExpression;

        void VisitFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IEditableFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> fieldGroup)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TTypeReference : IEditableTypeReference
            where TField : IEditableField;

        void VisitNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IEditableNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IEditableNestedClass
            where TAbstractClass : IEditableNestedAbstractClass
            where TSealedClass : IEditableNestedSealedClass
            where TStaticClass : IEditableNestedStaticClass
            where TPartialClassCollection : IEditablePartialClassCollection;

        void VisitNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TEventCollection : IEditableStaticClassEventCollection
            where TProperty : IEditableStaticClassProperty
            where TMethodCollection : IEditableNestedStaticClassMethodCollection
            where TFieldCollection : IEditableStaticClassFieldCollection
            where TNestedClassCollection : IEditableStaticClassNestedClassCollection
            where TNestedDelegate : IEditableStaticClassNestedDelegate
            where TNestedEnum : IEditableStaticClassNestedEnum
            where TNestedInterface : IEditableStaticClassNestedInterface
            where TNestedStructCollection : IEditableStaticClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitNestedStructCollection<TStruct, TPartialStruct>(
            IEditableNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IEditableNestedStruct
            where TPartialStruct : IEditableNestedPartialStruct;

        void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IEditableSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IEditableSealedClassEvent
            where TEventProperty : IEditableSealedClassEventProperty
            where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent;

        void VisitSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IEditableSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IEditableSealedClassIndexer
            where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer;

        void VisitSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IEditableSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IEditableSealedClassMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod;

        void VisitSealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IEditableSealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IEditableSealedClassMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
            where TPartialMethodDefinition : IEditablePartialMethodDefinition
            where TPartialMethodImplementation : IEditablePartialMethodImplementation;

        void VisitSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IEditableSealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IEditableSealedClassProperty
            where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty;

        void VisitSealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableSealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IEditableStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TTypeReference : IEditableTypeReference
            where TConstant : IEditableConstant;

        void VisitStaticClassEventCollection<TEvent, TEventProperty>(
            IEditableStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
            where TEvent : IEditableStaticClassEvent
            where TEventProperty : IEditableStaticClassEventProperty;

        void VisitStaticClassFieldCollection<TFieldGroup, TConstantGroup>(
            IEditableStaticClassFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IEditableStaticClassField
            where TConstantGroup : IEditableStaticClassConstant;

        void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(
            IEditableStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
            where TMethod : IEditableStaticClassMethod
            where TExtensionMethod : IEditableExtensionMethod;

        void VisitStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IEditableStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IEditableStaticClassMethod
            where TExtensionMethod : IEditableExtensionMethod
            where TPartialMethodDefinition : IEditablePartialMethodDefinition
            where TPartialMethodImplementation : IEditablePartialMethodImplementation;

        void VisitStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IEditableStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IEditableStaticClassNestedClass
            where TAbstractClass : IEditableStaticClassNestedAbstractClass
            where TSealedClass : IEditableStaticClassNestedSealedClass
            where TStaticClass : IEditableStaticClassNestedStaticClass
            where TPartialClassCollection : IEditablePartialClassCollection;

        void VisitStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(
            IEditableStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IEditableStaticClassNestedStruct
            where TPartialStruct : IEditableStaticClassNestedPartialStruct;

        void VisitStructCollection<TStruct, TPartialStruct>(IEditableStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IEditableStruct
            where TPartialStruct : IEditablePartialStruct;

        void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IEditableStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IEditableStructEvent
            where TEventProperty : IEditableStructEventProperty
            where TExplicitInterfaceEvent : IEditableExplicitInterfaceEvent;

        void VisitStructFieldCollection<TFieldGroup, TConstantGroup>(
            IEditableStructFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IEditableStructField
            where TConstantGroup : IEditableStructConstant;

        void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IEditableStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IEditableStructIndexer
            where TExplicitInterfaceIndexer : IEditableExplicitInterfaceIndexer;

        void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IEditableStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IEditableStructMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod;

        void VisitPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IEditablePartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IEditableStructMethod
            where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
            where TPartialMethodDefinition : IEditablePartialMethodDefinition
            where TPartialMethodImplementation : IEditablePartialMethodImplementation;

        void VisitStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableAbstractClassEventCollection
            where TPropertyCollection : IEditableAbstractClassPropertyCollection
            where TIndexerCollection : IEditableAbstractClassIndexerCollection
            where TMethodCollection : IEditableAbstractPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IEditableStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IEditableStructNestedClass
            where TAbstractClass : IEditableStructNestedAbstractClass
            where TSealedClass : IEditableStructNestedSealedClass
            where TStaticClass : IEditableStructNestedStaticClass
            where TPartialClassCollection : IEditablePartialClassCollection;

        void VisitStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IEditableStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TClassReference : IEditableClassReference
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableSealedClassEventCollection
            where TPropertyCollection : IEditableSealedClassPropertyCollection
            where TIndexerCollection : IEditableSealedClassIndexerCollection
            where TMethodCollection : IEditableSealedPartialClassMethodCollection
            where TFieldCollection : IEditableClassFieldCollection
            where TConstructor : IEditableClassConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableClassNestedClassCollection
            where TNestedDelegate : IEditableClassNestedDelegate
            where TNestedEnum : IEditableClassNestedEnum
            where TNestedInterface : IEditableClassNestedInterface
            where TNestedStructCollection : IEditableClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor
            where TDestructor : IEditableDestructor;

        void VisitStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TEventCollection : IEditableStaticClassEventCollection
            where TProperty : IEditableStaticClassProperty
            where TMethodCollection : IEditableNestedStaticClassMethodCollection
            where TFieldCollection : IEditableStaticClassFieldCollection
            where TNestedClassCollection : IEditableStaticClassNestedClassCollection
            where TNestedDelegate : IEditableStaticClassNestedDelegate
            where TNestedEnum : IEditableStaticClassNestedEnum
            where TNestedInterface : IEditableStaticClassNestedInterface
            where TNestedStructCollection : IEditableStaticClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
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
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStructNestedStructCollection<TStruct, TPartialStruct>(
            IEditableStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IEditableStructNestedStruct
            where TPartialStruct : IEditableStructNestedPartialStruct;

        void VisitStructPropertyCollection<TProperty, TExplicitInterfaceProperty>(
            IEditableStructPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IEditableStructProperty
            where TExplicitInterfaceProperty : IEditableExplicitInterfaceProperty;

        void VisitStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TInterfaceReference : IEditableInterfaceReference
            where TEventCollection : IEditableStructEventCollection
            where TPropertyCollection : IEditableStructPropertyCollection
            where TIndexerCollection : IEditableStructIndexerCollection
            where TMethodCollection : IEditableStructMethodCollection
            where TFieldCollection : IEditableStructFieldCollection
            where TConstructor : IEditableStructConstructor
            where TOperatorOverload : IEditableOperatorOverload
            where TConversionOperator : IEditableConversionOperator
            where TNestedClassCollection : IEditableStructNestedClassCollection
            where TNestedDelegate : IEditableStructNestedDelegate
            where TNestedEnum : IEditableStructNestedEnum
            where TNestedInterface : IEditableStructNestedInterface
            where TNestedStructCollection : IEditableStructNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IEditableStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStructType
            where TTypeReference : IEditableTypeReference
            where TConstant : IEditableConstant;

        void VisitExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(
            IEditableExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method)
            where TAttributeGroup : IEditableAttributeGroup
            where TDeclaringType : IEditableStaticClass
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TTypeReference : IEditableTypeReference
            where TExtensionParameter : IEditableExtensionParameter
            where TParameter : IEditableMethodParameter
            where TMethodBody : IEditableMethodBody;

        void VisitStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IEditableStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IEditableAttributeGroup
            where TGenericParameter : IEditableGenericParameterDeclaration
            where TEventCollection : IEditableStaticClassEventCollection
            where TProperty : IEditableStaticClassProperty
            where TMethodCollection : IEditableStaticClassMethodCollection
            where TFieldCollection : IEditableStaticClassFieldCollection
            where TNestedClassCollection : IEditableStaticClassNestedClassCollection
            where TNestedDelegate : IEditableStaticClassNestedDelegate
            where TNestedEnum : IEditableStaticClassNestedEnum
            where TNestedInterface : IEditableStaticClassNestedInterface
            where TNestedStructCollection : IEditableStaticClassNestedStructCollection
            where TStaticConstructor : IEditableStaticConstructor;

        void VisitNestedStaticClassMethodCollection<TMethod>(
            IEditableNestedStaticClassMethodCollection<TMethod> methodCollection)
            where TMethod : IEditableStaticClassMethod;

        void VisitNestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IEditableNestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IEditableStaticClassMethod
            where TPartialMethodDefinition : IEditablePartialMethodDefinition
            where TPartialMethodImplementation : IEditablePartialMethodImplementation;

        void VisitTypeReference(IEditableTypeReference typeReference);
    }
}