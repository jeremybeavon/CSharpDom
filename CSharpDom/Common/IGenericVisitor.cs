﻿using CSharpDom.Common.Expressions;
using CSharpDom.Common.Partial;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public interface IGenericVisitor
    {
        void Visit(IVisitable<IGenericVisitor> node);

        void VisitAbstractAccessor<TAttributeGroup>(IAbstractAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup;

        void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TAbstractEvent : IAbstractEvent
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent;

        void VisitAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IClassIndexer
            where TAbstractIndexer : IAbstractIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer;

        void VisitAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IClassMethod
            where TAbstractMethod : IAbstractMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IClassMethod
            where TAbstractMethod : IAbstractMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation;

        void VisitAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IClassProperty
            where TAutoProperty : IClassAutoProperty
            where TLambdaProperty : IClassLambdaProperty
            where TAbstractProperty : IAbstractProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty;

        void VisitAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TDelegateReference : IDelegateReference;

        void VisitAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAbstractAccessor;

        void VisitAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter;

        void VisitAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TAccessor : IAbstractAccessor;

        void VisitAccessor<TAttributeGroup, TMethodBody>(IAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody;

        void VisitAccessor<TAttributeGroup>(IAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup;

        Task VisitAsync(IAsyncVisitable<IGenericVisitor> node);

        void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
            where TTypeReference : ITypeReference;

        void VisitAttributeGroup<TAttribute>(IAttributeGroup<TAttribute> attributes)
            where TAttribute : IAttribute;

        void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
            where TClassReference : IClassReference
            where TUnnamedAttributeValue : IUnnamedAttributeValue
            where TNamedAttributeValue : INamedAttributeValue;

        void VisitBuiltInTypeReference(IBuiltInTypeReference builtInTypeReference);

        void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>(
            IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass> classes)
            where TClass : IClassType
            where TAbstractClass : IAbstractType
            where TSealedClass : ISealedType
            where TStaticClass : IStaticType;

        void VisitPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassAccessor<TAttributeGroup, TMethodBody>(IClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody;

        void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody;

        void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TDelegateReference : IDelegateReference;

        void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;

        void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TField : IField;

        void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IClassAccessor;

        void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;

        void VisitPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>(
            IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TParameter : IMethodParameter;

        void VisitPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>(
            IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;

        void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter;

        void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TNestedEnumMember : INestedEnumMember;

        void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod;

        void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
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
            where TStaticConstructor : IStaticConstructor;

        void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAccessor;

        void VisitClassReference<TTypeReference>(IClassReference<TTypeReference> classReference)
            where TTypeReference : ITypeReference;

        void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IOperatorParameter
            where TMethodBody : IMethodBody;

        void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter;

        void VisitDelegateReference<TTypeReference>(IDelegateReference<TTypeReference> delegateReference)
            where TTypeReference : ITypeReference;

        void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TMethodBody : IMethodBody;

        Task VisitDocumentAsync<TProject, TSolution, TLoadedDocument>(IDocument<TProject, TSolution, TLoadedDocument> document)
            where TProject : IProject
            where TSolution : ISolution
            where TLoadedDocument : ILoadedDocument;

        void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TEnumMember : IEnumMember;

        void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IEnum;

        void VisitEnumReference(IEnumReference enumReference);

        void VisitExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>(
            IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;

        void VisitExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>(
            IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAccessor;

        void VisitExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;

        void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TInterfaceReference : IInterfaceReference
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor;
        
        void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
            where TClassReference : IClassReference
            where TGenericParameterReference : IGenericParameterReference
            where TInterfaceReference : IInterfaceReference
            where TAttributeGroup : IAttributeGroup;

        void VisitGenericParameterReference(IGenericParameterReference genericParameterReference);

        void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod;

        void VisitInterfaceAccessor<TAttributeGroup>(IInterfaceAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup;

        void VisitInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TDelegateReference : IDelegateReference;

        void VisitInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IInterfaceAccessor;

        void VisitInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter;

        void VisitInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IInterfaceType
            where TTypeReference : ITypeReference
            where TAccessor : IInterfaceAccessor;

        void VisitInterfaceReference<TTypeReference>(IInterfaceReference<TTypeReference> interfaceReference)
            where TTypeReference : ITypeReference;

        void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> loadedDocument)
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TUsingDirective : IUsingDirective
            where TAttributeGroup : IAttributeGroup
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStructCollection : IStructCollection;

        void VisitMethodBody<TStatement>(IMethodBody<TStatement> methodBody);

        void VisitNamedAttributeValue<TExpression>(INamedAttributeValue<TExpression> namedAttributeValue)
            where TExpression : IExpression;

        void VisitNamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>(
            INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection> @namespace)
            where TUsingDirective : IUsingDirective
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStructCollection : IStructCollection;

        void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedEnum;

        void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
            where TTypeReference : ITypeReference;

        void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IOperatorParameter
            where TMethodBody : IMethodBody;

        void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        void VisitConstructorParameter<TAttributeGroup, TTypeReference>(
            IConstructorParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        void VisitDelegateParameter<TAttributeGroup, TTypeReference>(
            IDelegateParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        void VisitExtensionParameter<TAttributeGroup, TTypeReference>(
            IExtensionParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        void VisitIndexerParameter<TAttributeGroup, TTypeReference>(
            IIndexerParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        void VisitMethodParameter<TAttributeGroup, TTypeReference>(
            IMethodParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        void VisitOperatorParameter<TAttributeGroup, TTypeReference>(
            IOperatorParameter<TAttributeGroup, TTypeReference> parameter)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference;

        Task VisitProjectAsync<TSolution, TDocument, TLoadedProject>(IProject<TSolution, TDocument, TLoadedProject> project)
            where TSolution : ISolution
            where TDocument : IDocument
            where TLoadedProject : ILoadedProject;

        void VisitSealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            ISealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitSealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            ISealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitSealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TDelegateReference : IDelegateReference;

        void VisitSealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;
        
        void VisitSealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IClassAccessor;

        void VisitSealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;
        
        void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAccessor;

        Task VisitSolutionAsync<TProject>(ISolution<TProject> solution)
            where TProject : IProject;

        void VisitStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TMethodBody : IMethodBody;

        void VisitStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : IStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStaticClassAccessor<TAttributeGroup, TMethodBody>(IStaticClassAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody;
        
        void VisitStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TDelegateReference : IDelegateReference;

        void VisitStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;

        void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TField : IField;
        
        void VisitStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;

        void VisitStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStaticClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter;

        void VisitStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TNestedEnumMember : INestedEnumMember;

        void VisitStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod;

        void VisitStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
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
            where TStaticConstructor : IStaticConstructor;

        void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TAccessor : IStaticClassAccessor;

        void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
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
            where TStaticConstructor : IStaticConstructor;

        void VisitStructAccessor<TAttributeGroup, TMethodBody>(IStructAccessor<TAttributeGroup, TMethodBody> accessor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody;

        void VisitStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody;

        void VisitStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TDelegateReference : IDelegateReference;

        void VisitStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;

        void VisitStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TField : IField;

        void VisitStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IStructAccessor;

        void VisitStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;

        void VisitStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStructNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter;

        void VisitStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TNestedEnumMember : INestedEnumMember;

        void VisitStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod;

        void VisitStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
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
            where TStaticConstructor : IStaticConstructor;

        void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TAccessor : IStructAccessor;

        void VisitStructReference<TTypeReference>(IStructReference<TTypeReference> structReference)
            where TTypeReference : ITypeReference;

        void VisitUnnamedAttributeValue<TExpression>(IUnnamedAttributeValue<TExpression> unnamedAttributeValue)
            where TExpression : IExpression;

        void VisitUnspecifiedTypeReference<TTypeReference>(IUnspecifiedTypeReference<TTypeReference> unspecificTypeReference)
            where TTypeReference : ITypeReference;

        void VisitUsingDirective(IUsingDirective usingDirective);
        
        void VisitConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody;

        void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TDelegateReference : IDelegateReference;

        void VisitEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody;
        
        void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAccessor;

        void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;

        void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter;

        void VisitNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter;

        void VisitNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter;

        void VisitNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember;

        void VisitNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod;

        void VisitNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitNullableTypeReference<TStructReference>(INullableTypeReference<TStructReference> reference)
            where TStructReference : IStructReference;

        void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor;

        void VisitType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IEventCollection
            where TPropertyCollection : IPropertyCollection
            where TIndexerCollection : IIndexerCollection
            where TMethodCollection : IMethodCollection
            where TFieldCollection : IFieldCollection
            where TConstructor : IConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : INestedClassCollection
            where TNestedDelegate : INestedDelegate
            where TNestedEnum : INestedEnum
            where TNestedInterface : INestedInterface
            where TNestedStructCollection : INestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IClass
            where TAbstractClass : IAbstractClass
            where TSealedClass : ISealedClass
            where TStaticClass : IStaticClass
            where TPartialClassCollection : IPartialClassCollection;

        void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> classConstant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TConstant : IConstant;

        void VisitClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent;

        void VisitClassFieldCollection<TField, TConstant>(
            IClassFieldCollection<TField, TConstant> fieldCollection)
            where TField : IClassField
            where TConstant : IClassConstant;

        void VisitClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer;

        void VisitClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation;

        void VisitClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> nestedClass)
            where TClass : IClassNestedClass
            where TAbstractClass : IClassNestedAbstractClass
            where TSealedClass : IClassNestedSealedClass
            where TStaticClass : IClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection;
        
        void VisitClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : INestedStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : INestedStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitClassNestedStructCollection<TStruct, TPartialStruct>(
            IClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IClassNestedStruct
            where TPartialStruct : IClassNestedPartialStruct;

        void VisitClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IClassProperty
            where TAutoProperty : IClassAutoProperty
            where TLambdaProperty : IClassLambdaProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty;

        void VisitClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IClassEventCollection
            where TPropertyCollection : IClassPropertyCollection
            where TIndexerCollection : IClassIndexerCollection
            where TMethodCollection : IClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitConstant<TExpression>(IConstant<TExpression> constant)
            where TExpression : IExpression;

        void VisitConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constantGroup)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TConstant : IConstant;

        void VisitField<TExpression>(IField<TExpression> field)
            where TExpression : IExpression;

        void VisitFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> fieldGroup)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TField : IField;

        void VisitNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : INestedClass
            where TAbstractClass : INestedAbstractClass
            where TSealedClass : INestedSealedClass
            where TStaticClass : INestedStaticClass
            where TPartialClassCollection : IPartialClassCollection;
        
        void VisitNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @class)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitNestedStructCollection<TStruct, TPartialStruct>(
            INestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : INestedStruct
            where TPartialStruct : INestedPartialStruct;
        
        void VisitSealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : ISealedClassEvent
            where TEventProperty : ISealedClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent;
        
        void VisitSealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : ISealedClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer;

        void VisitSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>(
            ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : ISealedClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitSealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            ISealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : ISealedClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation;

        void VisitSealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : ISealedClassProperty
            where TAutoProperty : ISealedClassAutoProperty
            where TLambdaProperty : ISealedClassLambdaProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty;

        void VisitSealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            ISealedType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TConstant : IConstant;

        void VisitStaticClassEventCollection<TEvent, TEventProperty>(
            IStaticClassEventCollection<TEvent, TEventProperty> eventCollection)
            where TEvent : IStaticClassEvent
            where TEventProperty : IStaticClassEventProperty;

        void VisitStaticClassFieldCollection<TFieldGroup, TConstantGroup>(
            IStaticClassFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IStaticClassField
            where TConstantGroup : IStaticClassConstant;

        void VisitStaticClassMethodCollection<TMethod, TExtensionMethod>(
            IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection)
            where TMethod : IStaticClassMethod
            where TExtensionMethod : IExtensionMethod;

        void VisitStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IStaticClassMethod
            where TExtensionMethod : IExtensionMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation;

        void VisitStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IStaticClassNestedClass
            where TAbstractClass : IStaticClassNestedAbstractClass
            where TSealedClass : IStaticClassNestedSealedClass
            where TStaticClass : IStaticClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection;
        
        void VisitStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStaticClassNestedStructCollection<TStruct, TPartialStruct>(
            IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStaticClassNestedStruct
            where TPartialStruct : IStaticClassNestedPartialStruct;

        void VisitStructCollection<TStruct, TPartialStruct>(IStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStruct
            where TPartialStruct : IPartialStruct;

        void VisitStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection)
            where TEvent : IStructEvent
            where TEventProperty : IStructEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent;

        void VisitStructFieldCollection<TFieldGroup, TConstantGroup>(
            IStructFieldCollection<TFieldGroup, TConstantGroup> fieldCollection)
            where TFieldGroup : IStructField
            where TConstantGroup : IStructConstant;

        void VisitStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>(
            IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection)
            where TIndexer : IStructIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer;

        void VisitStructMethodCollection<TMethod, TExplicitInterfaceMethod>(
            IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection)
            where TMethod : IStructMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod;

        void VisitPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            IPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IStructMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation;

        void VisitStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IAbstractClassEventCollection
            where TPropertyCollection : IAbstractClassPropertyCollection
            where TIndexerCollection : IAbstractClassIndexerCollection
            where TMethodCollection : IAbstractPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection)
            where TClass : IStructNestedClass
            where TAbstractClass : IStructNestedAbstractClass
            where TSealedClass : IStructNestedSealedClass
            where TStaticClass : IStructNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection;
        
        void VisitStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> nestedStruct)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : ISealedClassEventCollection
            where TPropertyCollection : ISealedClassPropertyCollection
            where TIndexerCollection : ISealedClassIndexerCollection
            where TMethodCollection : ISealedPartialClassMethodCollection
            where TFieldCollection : IClassFieldCollection
            where TConstructor : IClassConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IClassNestedClassCollection
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStructCollection : IClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
            where TDestructor : IDestructor;

        void VisitStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> nestedClass)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : INestedStaticPartialClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStructNestedStructCollection<TStruct, TPartialStruct>(
            IStructNestedStructCollection<TStruct, TPartialStruct> structCollection)
            where TStruct : IStructNestedStruct
            where TPartialStruct : IStructNestedPartialStruct;

        void VisitStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty> propertyCollection)
            where TProperty : IStructProperty
            where TAutoProperty : IStructAutoProperty
            where TLambdaProperty : IStructLambdaProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty;

        void VisitStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEventCollection : IStructEventCollection
            where TPropertyCollection : IStructPropertyCollection
            where TIndexerCollection : IStructIndexerCollection
            where TMethodCollection : IStructMethodCollection
            where TFieldCollection : IStructFieldCollection
            where TConstructor : IStructConstructor
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClassCollection : IStructNestedClassCollection
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TConstant : IConstant;
        
        void VisitExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(
            IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticClass
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TExtensionParameter : IExtensionParameter
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody;

        void VisitStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> type)
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TPropertyCollection : IStaticClassPropertyCollection
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterface : IStaticClassNestedInterface
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor;

        void VisitNestedStaticClassMethodCollection<TMethod>(INestedStaticClassMethodCollection<TMethod> methodCollection)
            where TMethod : IStaticClassMethod;

        void VisitNestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation>(
            INestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation> methodCollection)
            where TMethod : IStaticClassMethod
            where TPartialMethodDefinition : IPartialMethodDefinition
            where TPartialMethodImplementation : IPartialMethodImplementation;

        void VisitTypeReference(ITypeReference typeReference);

        void VisitAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TAccessor : IAutoPropertyAccessor
            where TExpression : IExpression;

        void VisitLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAutoPropertyAccessor
            where TExpression : IExpression;

        void VisitClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitSealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            ISealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TAccessor : IClassAutoPropertyAccessor
            where TExpression : IExpression;

        void VisitSealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            ISealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : ISealedType
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitStaticClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IStaticClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TAccessor : IStaticClassAutoPropertyAccessor
            where TExpression : IExpression;

        void VisitStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitStructAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>(
            IStructAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TAccessor : IStructAutoPropertyAccessor
            where TExpression : IExpression;

        void VisitStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>(
            IStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> property)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TExpression : IExpression;

        void VisitStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty>(
            IStaticClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty> propertyCollection)
            where TProperty : IStaticClassProperty
            where TAutoProperty : IStaticClassAutoProperty
            where TLambdaProperty : IStaticClassLambdaProperty;

        void VisitAutoPropertyAccessor<TAttributeGroup>(IAutoPropertyAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup;

        void VisitClassAutoPropertyAccessor<TAttributeGroup>(IClassAutoPropertyAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup;

        void VisitStaticClassAutoPropertyAccessor<TAttributeGroup>(
            IStaticClassAutoPropertyAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup;

        void VisitStructAutoPropertyAccessor<TAttributeGroup>(IStructAutoPropertyAccessor<TAttributeGroup> accessor)
            where TAttributeGroup : IAttributeGroup;
    }
}
