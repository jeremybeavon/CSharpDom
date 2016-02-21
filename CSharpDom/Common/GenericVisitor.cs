using CSharpDom.BaseClasses.Wrappers;
using CSharpDom.Common.Partial;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public static class GenericVisitor
    {
        public static void VisitAccessor<TAttributeGroup, TMethodBody>(
            IAccessor<TAttributeGroup, TMethodBody> accessor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TMethodBody : IMethodBody
        {
            VisitCollection(accessor.Attributes, visitor);
            VisitIfNotNull(accessor.Body, visitor);
        }

        public static void VisitArrayTypeReferenceChildren<TTypeReference>(
            IArrayTypeReference<TTypeReference> arrayTypeReference,
            IGenericVisitor visitor)
            where TTypeReference : ITypeReference
        {
            VisitIfNotNull(arrayTypeReference.ElementType, visitor);
        }

        public static void VisitAttributeGroupChildren<TAttribute>(
            IAttributeGroup<TAttribute> attributeGroup,
            IGenericVisitor visitor)
            where TAttribute : IAttribute
        {
            VisitCollection(attributeGroup.Attributes, visitor);
        }

        public static void VisitAttributeChildren<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute,
            IGenericVisitor visitor)
            where TClassReference : IClassReference
            where TUnnamedAttributeValue : IUnnamedAttributeValue
            where TNamedAttributeValue : INamedAttributeValue
        {
            VisitIfNotNull(attribute.AttributeType, visitor);
            VisitCollection(attribute.UnnamedValues, visitor);
            VisitCollection(attribute.NamedValues, visitor);
        }

        public static void VisitClassChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
        {
            VisitIfNotNull(@class.BaseClass, visitor);
            VisitCollection(@class.ImplementedInterfaces, visitor);
            VisitCollection(@class.Attributes, visitor);
            VisitCollection(@class.GenericParameters, visitor);
            new TypeWrapper<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(@class).Accept(visitor);
        }

        public static void VisitClassReferenceChildren<TGenericParameter>(
            IClassReference<TGenericParameter> classReference,
            IGenericVisitor visitor)
            where TGenericParameter : IGenericParameter
        {
            VisitCollection(classReference.GenericParameters, visitor);
        }

        public static void VisitClassConstructorChildren<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody
        {
            new ConstructorWrapper<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(constructor).Accept(visitor);
        }

        public static void VisitStructConstructorChildren<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody
        {
            new ConstructorWrapper<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(constructor).Accept(visitor);
        }

        public static void VisitConstructorChildren<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IConstructorParameter
            where TMethodBody : IMethodBody
        {
            VisitCollection(constructor.Attributes, visitor);
            VisitCollection(constructor.Parameters, visitor);
        }

        public static void VisitConversionOperatorChildren<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IOperatorParameter
            where TMethodBody : IMethodBody
        {
            VisitCollection(conversionOperator.Attributes, visitor);
            VisitCollection(conversionOperator.ReturnAttributes, visitor);
            VisitIfNotNull(conversionOperator.ReturnType, visitor);
            VisitIfNotNull(conversionOperator.Parameter, visitor);
            VisitIfNotNull(conversionOperator.Body, visitor);
        }

        public static void VisitDelegateChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate,
            IGenericVisitor visitor)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            VisitCollection(@delegate.Attributes, visitor);
            VisitCollection(@delegate.GenericParameters, visitor);
            VisitIfNotNull(@delegate.ReturnType, visitor);
            VisitCollection(@delegate.Parameters, visitor);
        }

        public static void VisitDelegateReferenceChildren<TGenericParameter>(
            IDelegateReference<TGenericParameter> delegateReference,
            IGenericVisitor visitor)
            where TGenericParameter : IGenericParameter
        {
            VisitCollection(delegateReference.GenericParameters, visitor);
        }

        public static void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClass
            where TMethodBody : IMethodBody
        {
            VisitCollection(destructor.Attributes, visitor);
            VisitIfNotNull(destructor.Body, visitor);
        }

        public static async Task VisitDocumentChildrenAsync<TProject, TSolution, TLoadedDocument>(
            IDocument<TProject, TSolution, TLoadedDocument> document,
            IGenericVisitor visitor)
            where TProject : IProject
            where TSolution : ISolution
            where TLoadedDocument : ILoadedDocument
        {
            (await document.LoadAsync()).Accept(visitor);
        }

        public static void VisitEnumChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum,
            IGenericVisitor visitor)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TEnumMember : IEnumMember
        {
            VisitCollection(@enum.Attributes, visitor);
            VisitCollection(@enum.EnumMembers, visitor);
        }

        public static void VisitEnumMemberChildren<TAttributeGroup, TDeclaringType>(
            IEnumMember<TAttributeGroup, TDeclaringType> enumMember,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IEnum
        {
            VisitCollection(enumMember.Attributes, visitor);
        }

        public static void VisitEventChildren<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TDelegateReference : IDelegateReference
        {
            VisitCollection(@event.Attributes, visitor);
            //VisitCollection(@event.FieldAttributes, visitor);
            VisitIfNotNull(@event.EventType, visitor);
        }

        public static void VisitEventPropertyChildren<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TDelegateReference : IDelegateReference
            where TMethodBody : IMethodBody
        {
            VisitCollection(eventProperty.Attributes, visitor);
            VisitIfNotNull(eventProperty.EventType, visitor);
            VisitIfNotNull(eventProperty.AddBody, visitor);
            VisitIfNotNull(eventProperty.RemoveBody, visitor);
        }

        public static void VisitFieldGroupChildren<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> field,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            VisitCollection(field.Attributes, visitor);
            VisitIfNotNull(field.FieldType, visitor);
            VisitCollection(field.Fields, visitor);
        }

        public static void VisitConstantGroupChildren<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            VisitCollection(field.Attributes, visitor);
            VisitIfNotNull(field.FieldType, visitor);
            VisitCollection(field.Constants, visitor);
        }

        public static void VisitGenericParameter<TTypeReference>(
            IGenericParameter<TTypeReference> genericParameter,
            IGenericVisitor visitor)
            where TTypeReference : ITypeReference
        {
            VisitIfNotNull(genericParameter.Type, visitor);
        }

        public static void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration,
            IGenericVisitor visitor)
            where TClassReference : IClassReference
            where TGenericParameterReference : IGenericParameterReference
            where TInterfaceReference : IInterfaceReference
            where TAttributeGroup : IAttributeGroup
        {
            VisitCollection(genericParameterDeclaration.Attributes, visitor);
            VisitIfNotNull(genericParameterDeclaration.BaseClassConstraint, visitor);
            VisitCollection(genericParameterDeclaration.GenericParameterConstraints, visitor);
            VisitCollection(genericParameterDeclaration.InterfaceConstraints, visitor);
        }

        public static void VisitIndexerChildren<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAccessor
        {
            VisitCollection(indexer.Attributes, visitor);
            VisitIfNotNull(indexer.IndexerType, visitor);
            VisitCollection(indexer.Parameters, visitor);
            VisitIfNotNull(indexer.GetAccessor, visitor);
            VisitIfNotNull(indexer.SetAccessor, visitor);
        }

        public static void VisitInterfaceChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface,
            IGenericVisitor visitor)
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
            where TMethod : IInterfaceMethod
        {
            VisitCollection(@interface.Attributes, visitor);
            VisitCollection(@interface.GenericParameters, visitor);
            VisitCollection(@interface.Interfaces, visitor);
            VisitCollection(@interface.Events, visitor);
            VisitCollection(@interface.Properties, visitor);
            VisitCollection(@interface.Indexers, visitor);
            VisitCollection(@interface.Methods, visitor);
        }

        public static void VisitInterfaceAccessorChildren<TAttributeGroup>(
            IInterfaceAccessor<TAttributeGroup> accessor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
        {
            VisitCollection(accessor.Attributes, visitor);
        }

        public static void VisitInterfaceReferenceChildren<TGenericParameter>(
            IInterfaceReference<TGenericParameter> interfaceReference,
            IGenericVisitor visitor)
            where TGenericParameter : IGenericParameter
        {
            VisitCollection(interfaceReference.GenericParameters, visitor);
        }

        public static void VisitLoadedDocumentChildren<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> loadedDocument,
            IGenericVisitor visitor)
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TUsingDirective : IUsingDirective
            where TAttributeGroup : IAttributeGroup
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterfaceCollection : IInterfaceCollection
            where TStructCollection : IStructCollection
        {
            VisitCollection(loadedDocument.UsingDirectives, visitor);
            VisitCollection(loadedDocument.AssemblyAttributes, visitor);
            VisitCollection(loadedDocument.ModuleAttributes, visitor);
            VisitCollection(loadedDocument.Namespaces, visitor);
            VisitIfNotNull(loadedDocument.Classes, visitor);
            VisitCollection(loadedDocument.Delegates, visitor);
            VisitCollection(loadedDocument.Enums, visitor);
            VisitIfNotNull(loadedDocument.Interfaces, visitor);
            VisitIfNotNull(loadedDocument.Structs, visitor);
        }

        public static void VisitMethodChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
        {
            VisitCollection(method.Attributes, visitor);
            VisitCollection(method.GenericParameters, visitor);
            VisitIfNotNull(method.ReturnType, visitor);
            VisitCollection(method.Parameters, visitor);
        }
        
        public static void VisitMethodChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            VisitCollection(method.Attributes, visitor);
            VisitCollection(method.GenericParameters, visitor);
            VisitIfNotNull(method.ReturnType, visitor);
            VisitCollection(method.Parameters, visitor);
            VisitIfNotNull(method.Body, visitor);
        }

        public static void VisitNamespaceChildren<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection>(
            INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterfaceCollection, TStructCollection> @namespace,
            IGenericVisitor visitor)
            where TUsingDirective : IUsingDirective
            where TNamespace : INamespace
            where TClassCollection : IClassCollection
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterfaceCollection : IInterfaceCollection
            where TStructCollection : IStructCollection
        {
            VisitCollection(@namespace.UsingDirectives, visitor);
            VisitCollection(@namespace.Namespaces, visitor);
            VisitIfNotNull(@namespace.Classes, visitor);
            VisitCollection(@namespace.Delegates, visitor);
            VisitCollection(@namespace.Enums, visitor);
            VisitIfNotNull(@namespace.Interfaces, visitor);
            VisitIfNotNull(@namespace.Structs, visitor);
        }

        public static void VisitNestedClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            VisitCollection(nestedClass.Attributes, visitor);
            VisitCollection(nestedClass.GenericParameters, visitor);
            VisitIfNotNull(nestedClass.BaseClass, visitor);
            VisitCollection(nestedClass.ImplementedInterfaces, visitor);
            visitor.VisitType(nestedClass);
            VisitIfNotNull(nestedClass.Destructor, visitor);
        }

        public static void VisitNestedDelegateChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IDelegateParameter
        {
            VisitCollection(nestedDelegate.Attributes, visitor);
            VisitCollection(nestedDelegate.GenericParameters, visitor);
            VisitIfNotNull(nestedDelegate.ReturnType, visitor);
            VisitCollection(nestedDelegate.Parameters, visitor);
        }

        public static void VisitNestedDestructorChildren<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedClass
            where TMethodBody : IMethodBody
        {
            VisitCollection(nestedDestructor.Attributes, visitor);
            VisitIfNotNull(nestedDestructor.Body, visitor);
        }

        public static void VisitNestedEnumChildren<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TNestedEnumMember : INestedEnumMember
        {
            VisitCollection(nestedEnum.Attributes, visitor);
            VisitCollection(nestedEnum.EnumMembers, visitor);
        }

        public static void VisitNestedEnumMemberChildren<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : INestedEnum
        {
            VisitCollection(nestedEnumMember.Attributes, visitor);
        }

        public static void VisitNestedInterfaceChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IInterfaceEvent
            where TProperty : IInterfaceProperty
            where TIndexer : IInterfaceIndexer
            where TMethod : IInterfaceMethod
        {
            VisitCollection(@interface.Interfaces, visitor);
            VisitCollection(@interface.Events, visitor);
            VisitCollection(@interface.Properties, visitor);
            VisitCollection(@interface.Indexers, visitor);
            VisitCollection(@interface.Methods, visitor);
        }

        public static void VisitNestedStructChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedStruct,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            VisitCollection(nestedStruct.Attributes, visitor);
            VisitCollection(nestedStruct.GenericParameters, visitor);
            VisitCollection(nestedStruct.ImplementedInterfaces, visitor);
            new StructTypeWrapper<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(nestedStruct).Accept(visitor);
        }

        public static void VisitNestedTypeReferenceChildren<TTypeReference>(
            INestedTypeReference<TTypeReference> nestedTypeReference,
            IGenericVisitor visitor)
            where TTypeReference : ITypeReference
        {
            VisitIfNotNull(nestedTypeReference.Type, visitor);
            VisitIfNotNull(nestedTypeReference.NestedType, visitor);
        }

        public static void VisitNullableTypeReference<TStructReference>(
            INullableTypeReference<TStructReference> reference,
            IGenericVisitor visitor)
            where TStructReference : IStructReference
        {
            VisitIfNotNull(reference.Type, visitor);
        }

        public static void VisitOperatorOverloadChildren<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
            where TParameter : IOperatorParameter
            where TMethodBody : IMethodBody
        {
            VisitCollection(operatorOverload.Attributes, visitor);
            VisitIfNotNull(operatorOverload.ReturnType, visitor);
            VisitCollection(operatorOverload.Parameters, visitor);
            VisitIfNotNull(operatorOverload.Body, visitor);
        }

        public static void VisitParameterChildren<TAttributeGroup, TTypeReference>(
            IParameter<TAttributeGroup, TTypeReference> parameter,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            VisitCollection(parameter.Attributes, visitor);
            VisitIfNotNull(parameter.ParameterType, visitor);
        }

        public static void VisitConstructorParameterChildren<TAttributeGroup, TTypeReference>(
            IConstructorParameter<TAttributeGroup, TTypeReference> parameter,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            new ParameterWrapper<TAttributeGroup, TTypeReference>(parameter).Accept(visitor);
        }

        public static void VisitDelegateParameterChildren<TAttributeGroup, TTypeReference>(
            IDelegateParameter<TAttributeGroup, TTypeReference> parameter,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            new ParameterWrapper<TAttributeGroup, TTypeReference>(parameter).Accept(visitor);
        }

        public static void VisitExtensionParameterChildren<TAttributeGroup, TTypeReference>(
            IExtensionParameter<TAttributeGroup, TTypeReference> parameter,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            new ParameterWrapper<TAttributeGroup, TTypeReference>(parameter).Accept(visitor);
        }

        public static void VisitIndexerParameterChildren<TAttributeGroup, TTypeReference>(
            IIndexerParameter<TAttributeGroup, TTypeReference> parameter,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            new ParameterWrapper<TAttributeGroup, TTypeReference>(parameter).Accept(visitor);
        }

        public static void VisitMethodParameterChildren<TAttributeGroup, TTypeReference>(
            IMethodParameter<TAttributeGroup, TTypeReference> parameter,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            new ParameterWrapper<TAttributeGroup, TTypeReference>(parameter).Accept(visitor);
        }

        public static void VisitOperatorParameterChildren<TAttributeGroup, TTypeReference>(
            IOperatorParameter<TAttributeGroup, TTypeReference> parameter,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TTypeReference : ITypeReference
        {
            new ParameterWrapper<TAttributeGroup, TTypeReference>(parameter).Accept(visitor);
        }

        public static Task VisitProjectChildrenAsync<TSolution, TDocument, TLoadedProject>(
            IProject<TSolution, TDocument, TLoadedProject> project,
            IGenericVisitor visitor)
            where TSolution : ISolution
            where TDocument : IDocument
            where TLoadedProject : ILoadedProject
        {
            return VisitCollectionAsync(project.Documents, visitor);
        }

        public static void VisitPropertyChildren<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TTypeReference : ITypeReference
            where TAccessor : IAccessor
        {
            VisitCollection(property.Attributes, visitor);
            VisitIfNotNull(property.GetAccessor, visitor);
            VisitIfNotNull(property.SetAccessor, visitor);
        }

        public static async Task VisitSolutionChildrenAsync<TProject>(ISolution<TProject> solution, IGenericVisitor visitor)
            where TProject : IProject
        {
            await VisitCollectionAsync(solution.Projects, visitor);
        }

        public static void VisitStaticConstructorChildren<TAttributeGroup, TDeclaringType, TMethodBody>(
            IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody> staticConstructor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TMethodBody : IMethodBody
        {
            VisitCollection(staticConstructor.Attributes, visitor);
            VisitIfNotNull(staticConstructor.Body, visitor);
        }

        public static void VisitStructChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @struct,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            VisitCollection(@struct.Attributes, visitor);
            VisitCollection(@struct.GenericParameters, visitor);
            VisitCollection(@struct.ImplementedInterfaces, visitor);
        }

        public static void VisitStructReferenceChildren<TGenericParameter>(
            IStructReference<TGenericParameter> structReference,
            IGenericVisitor visitor)
            where TGenericParameter : IGenericParameter
        {
            VisitCollection(structReference.GenericParameters, visitor);
        }

        public static void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecifiedTypeReference<TGenericParameter> unspecificTypeReference,
            IGenericVisitor visitor)
            where TGenericParameter : IGenericParameter
        {
            VisitCollection(unspecificTypeReference.GenericParameters, visitor);
        }

        public static void VisitCollection<T, TVisitor>(IReadOnlyCollection<T> collection, TVisitor visitor)
            where T : IVisitable<TVisitor>
        {
            foreach (T item in collection)
            {
                item.Accept(visitor);
            }
        }

        public static async Task VisitCollectionAsync<T, TVisitor>(IReadOnlyCollection<T> collection, TVisitor visitor)
            where T : IAsyncVisitable<TVisitor>
        {
            foreach (T item in collection)
            {
                await item.AcceptAsync(visitor);
            }
        }

        public static void VisitIfNotNull<TVisitor>(IVisitable<TVisitor> visitable, TVisitor visitor)
        {
            if (visitable != null)
            {
                visitable.Accept(visitor);
            }
        }

        public static void VisitTypeChildren<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : INestedInterfaceCollection
            where TNestedStructCollection : INestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            VisitIfNotNull(type.Events, visitor);
            VisitIfNotNull(type.Properties, visitor);
            VisitIfNotNull(type.Indexers, visitor);
            VisitIfNotNull(type.Methods, visitor);
            VisitIfNotNull(type.Fields, visitor);
            VisitCollection(type.Constructors, visitor);
            VisitCollection(type.OperatorOverloads, visitor);
            VisitCollection(type.ConversionOperators, visitor);
            VisitIfNotNull(type.Classes, visitor);
            VisitCollection(type.Delegates, visitor);
            VisitCollection(type.Enums, visitor);
            VisitIfNotNull(type.Interfaces, visitor);
            VisitIfNotNull(type.Structs, visitor);
            VisitIfNotNull(type.StaticConstructor, visitor);
        }

        public static void VisitStructTypeChildren<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStructType<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IStructNestedInterfaceCollection
            where TNestedStructCollection : IStructNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            new TypeWrapper<TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(type).Accept(visitor);
        }

        public static void VisitAbstractClassEventCollectionChildren<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>(
            IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent> eventCollection,
            IGenericVisitor visitor)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TAbstractEvent : IAbstractEvent
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.AbstractEvents, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitAbstractClassIndexerCollectionChildren<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>(
            IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer> indexerCollection,
            IGenericVisitor visitor)
            where TIndexer : IClassIndexer
            where TAbstractIndexer : IAbstractIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.AbstractIndexers, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitAbstractClassMethodCollectionChildren<TMethod, TAbstractMethod, TExplicitInterfaceMethod>(
            IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methodCollection,
            IGenericVisitor visitor)
            where TMethod : IClassMethod
            where TAbstractMethod : IAbstractMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.AbstractMethods, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitAbstractClassPropertyCollectionChildren<TProperty, TAbstractProperty, TExplicitInterfaceProperty>(
            IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty> propertyCollection,
            IGenericVisitor visitor)
            where TProperty : IClassProperty
            where TAbstractProperty : IAbstractProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.AbstractProperties, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitClassEventCollectionChildren<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection,
            IGenericVisitor visitor)
            where TEvent : IClassEvent
            where TEventProperty : IClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitClassIndexerCollectionChildren<TIndexer, TExplicitInterfaceIndexer>(
            IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection,
            IGenericVisitor visitor)
            where TIndexer : IClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitClassMethodCollectionChildren<TMethod, TExplicitInterfaceMethod>(
            IClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection,
            IGenericVisitor visitor)
            where TMethod : IClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitClassPropertyCollectionChildren<TProperty, TExplicitInterfaceProperty>(
            IClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection,
            IGenericVisitor visitor)
            where TProperty : IClassProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitSealedClassEventCollectionChildren<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection,
            IGenericVisitor visitor)
            where TEvent : ISealedClassEvent
            where TEventProperty : ISealedClassEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitSealedClassIndexerCollectionChildren<TIndexer, TExplicitInterfaceIndexer>(
            ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection,
            IGenericVisitor visitor)
            where TIndexer : ISealedClassIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitSealedClassMethodCollectionChildren<TMethod, TExplicitInterfaceMethod>(
            ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection,
            IGenericVisitor visitor)
            where TMethod : ISealedClassMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitSealedClassPropertyCollectionChildren<TProperty, TExplicitInterfaceProperty>(
            ISealedClassPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection,
            IGenericVisitor visitor)
            where TProperty : ISealedClassProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitStructEventCollectionChildren<TEvent, TEventProperty, TExplicitInterfaceEvent>(
            IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent> eventCollection,
            IGenericVisitor visitor)
            where TEvent : IStructEvent
            where TEventProperty : IStructEventProperty
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitStructIndexerCollectionChildren<TIndexer, TExplicitInterfaceIndexer>(
            IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer> indexerCollection,
            IGenericVisitor visitor)
            where TIndexer : IStructIndexer
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitStructMethodCollectionChildren<TMethod, TExplicitInterfaceMethod>(
            IStructMethodCollection<TMethod, TExplicitInterfaceMethod> methodCollection,
            IGenericVisitor visitor)
            where TMethod : IStructMethod
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitStructPropertyCollectionChildren<TProperty, TExplicitInterfaceProperty>(
            IStructPropertyCollection<TProperty, TExplicitInterfaceProperty> propertyCollection,
            IGenericVisitor visitor)
            where TProperty : IStructProperty
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitClassFieldChildren<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            new FieldGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TField>(field).Accept(visitor);
        }

        public static void VisitClassConstantChildren<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> classConstant,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            new ConstantGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(classConstant).Accept(visitor);
        }

        public static void VisitStaticClassConstantChildren<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> classConstant,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            new ConstantGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(classConstant).Accept(visitor);
        }

        public static void VisitClassFieldCollectionChildren<TField, TConstant>(
            IClassFieldCollection<TField, TConstant> fieldCollection,
            IGenericVisitor visitor)
            where TField : IClassField
            where TConstant : IClassConstant
        {
            VisitCollection(fieldCollection, visitor);
            VisitCollection(fieldCollection.Constants, visitor);
        }

        public static void VisitStaticClassFieldCollectionChildren<TField, TConstant>(
            IStaticClassFieldCollection<TField, TConstant> fieldCollection,
            IGenericVisitor visitor)
            where TField : IStaticClassField
            where TConstant : IStaticClassConstant
        {
            VisitCollection(fieldCollection, visitor);
            VisitCollection(fieldCollection.Constants, visitor);
        }

        public static void VisitStructFieldChildren<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TField : IField
        {
            new FieldGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TField>(field).Accept(visitor);
        }

        public static void VisitStructConstantChildren<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> constant,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TTypeReference : ITypeReference
            where TConstant : IConstant
        {
            new ConstantGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(constant).Accept(visitor);
        }

        public static void VisitClassCollectionChildren<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection,
            IGenericVisitor visitor)
            where TClass : IClass
            where TAbstractClass : IAbstractClass
            where TSealedClass : ISealedClass
            where TStaticClass : IStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            VisitCollection(classCollection, visitor);
            VisitCollection(classCollection.AbstractClasses, visitor);
            VisitCollection(classCollection.SealedClasses, visitor);
            VisitCollection(classCollection.StaticClasses, visitor);
            VisitIfNotNull(classCollection.PartialClasses, visitor);
        }

        public static void VisitStructCollectionChildren<TStruct, TPartialStruct>(
            IStructCollection<TStruct, TPartialStruct> structCollection,
            IGenericVisitor visitor)
            where TStruct : IStruct
            where TPartialStruct : IPartialStruct
        {
            VisitCollection(structCollection, visitor);
            VisitCollection(structCollection.PartialStructs, visitor);
        }

        public static void VisitInterfaceCollectionChildren<TInterface, TPartialInterface>(
            IInterfaceCollection<TInterface, TPartialInterface> interfaceCollection,
            IGenericVisitor visitor)
            where TInterface : IInterface
            where TPartialInterface : IPartialInterface
        {
            VisitCollection(interfaceCollection, visitor);
            VisitCollection(interfaceCollection.PartialInterfaces, visitor);
        }

        public static void VisitAbstractAccessorChildren<TAttributeGroup>(
            IAbstractAccessor<TAttributeGroup> accessor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
        {
            VisitCollection(accessor.Attributes, visitor);
        }

        public static void VisitAbstractEventChildren<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TDelegateReference : IDelegateReference
        {
            new EventWrapper<TAttributeGroup, TDeclaringType, TDelegateReference>(@event).Accept(visitor);
        }

        public static void VisitAbstractIndexerChildren<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TParameter : IIndexerParameter
            where TAccessor : IAbstractAccessor
        {
            new IndexerWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(indexer).Accept(visitor);
        }

        public static void VisitAbstractPropertyChildren<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IAbstractType
            where TTypeReference : ITypeReference
            where TAccessor : IAbstractAccessor
        {
            new PropertyWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(property).Accept(visitor);
        }

        public static void VisitExtensionMethodChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>(
            IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody> method,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticClass
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TExtensionParameter : IExtensionParameter
            where TParameter : IMethodParameter
            where TMethodBody : IMethodBody
        {
            throw new NotImplementedException();
        }

        public static void VisitNestedInterfaceCollectionChildren<TInterface, TPartialInterface>(
            INestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection,
            IGenericVisitor visitor)
            where TInterface : INestedInterface
            where TPartialInterface : IPartialInterface
        {
            VisitCollection(interfaceCollection, visitor);
            VisitCollection(interfaceCollection.PartialInterfaces, visitor);
        }

        public static void VisitClassNestedInterfaceCollectionChildren<TInterface, TPartialInterface>(
            IClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection,
            IGenericVisitor visitor)
            where TInterface : IClassNestedInterface
            where TPartialInterface : IPartialInterface
        {
            new NestedInterfaceCollectionWrapper<TInterface, TPartialInterface>(interfaceCollection).Accept(visitor);
        }

        public static void VisitStaticClassNestedInterfaceCollectionChildren<TInterface, TPartialInterface>(
            IStaticClassNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection,
            IGenericVisitor visitor)
            where TInterface : IStaticClassNestedInterface
            where TPartialInterface : IPartialInterface
        {
            new NestedInterfaceCollectionWrapper<TInterface, TPartialInterface>(interfaceCollection).Accept(visitor);
        }

        public static void VisitStructNestedInterfaceCollectionChildren<TInterface, TPartialInterface>(
            IStructNestedInterfaceCollection<TInterface, TPartialInterface> interfaceCollection,
            IGenericVisitor visitor)
            where TInterface : IStructNestedInterface
            where TPartialInterface : IPartialInterface
        {
            new NestedInterfaceCollectionWrapper<TInterface, TPartialInterface>(interfaceCollection).Accept(visitor);
        }

        public static void VisitNestedStructCollectionChildren<TStruct, TPartialStruct>(
            INestedStructCollection<TStruct, TPartialStruct> structCollection,
            IGenericVisitor visitor)
            where TStruct : INestedStruct
            where TPartialStruct : IPartialStruct
        {
            VisitCollection(structCollection, visitor);
            VisitCollection(structCollection.PartialStructs, visitor);
        }

        public static void VisitClassNestedStructCollectionChildren<TStruct, TPartialStruct>(
            IClassNestedStructCollection<TStruct, TPartialStruct> structCollection,
            IGenericVisitor visitor)
            where TStruct : IClassNestedStruct
            where TPartialStruct : IPartialStruct
        {
            new NestedStructCollectionWrapper<TStruct, TPartialStruct>(structCollection).Accept(visitor);
        }

        public static void VisitStaticClassNestedStructCollectionChildren<TStruct, TPartialStruct>(
            IStaticClassNestedStructCollection<TStruct, TPartialStruct> structCollection,
            IGenericVisitor visitor)
            where TStruct : IStaticClassNestedStruct
            where TPartialStruct : IPartialStruct
        {
            new NestedStructCollectionWrapper<TStruct, TPartialStruct>(structCollection).Accept(visitor);
        }

        public static void VisitStructNestedStructCollectionChildren<TStruct, TPartialStruct>(
            IStructNestedStructCollection<TStruct, TPartialStruct> structCollection,
            IGenericVisitor visitor)
            where TStruct : IStructNestedStruct
            where TPartialStruct : IPartialStruct
        {
            new NestedStructCollectionWrapper<TStruct, TPartialStruct>(structCollection).Accept(visitor);
        }

        public static void VisitNestedClassCollectionChildren<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> classCollection,
            IGenericVisitor visitor)
            where TClass : INestedClass
            where TAbstractClass : INestedAbstractClass
            where TSealedClass : INestedSealedClass
            where TStaticClass : INestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            VisitCollection(classCollection, visitor);
            VisitCollection(classCollection.AbstractClasses, visitor);
            VisitCollection(classCollection.SealedClasses, visitor);
            VisitCollection(classCollection.StaticClasses, visitor);
            VisitIfNotNull(classCollection.PartialClasses, visitor);
        }

        public static void VisitClassNestedClassCollectionChildren<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> nestedClass,
            IGenericVisitor visitor)
            where TClass : IClassNestedClass
            where TAbstractClass : IClassNestedAbstractClass
            where TSealedClass : IClassNestedSealedClass
            where TStaticClass : IClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            new NestedClassCollectionWrapper<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedClassCollectionChildren<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> nestedClass,
            IGenericVisitor visitor)
            where TClass : IStaticClassNestedClass
            where TAbstractClass : IStaticClassNestedAbstractClass
            where TSealedClass : IStaticClassNestedSealedClass
            where TStaticClass : IStaticClassNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            new NestedClassCollectionWrapper<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedClassCollectionChildren<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(
            IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection> nestedClass,
            IGenericVisitor visitor)
            where TClass : IStructNestedClass
            where TAbstractClass : IStructNestedAbstractClass
            where TSealedClass : IStructNestedSealedClass
            where TStaticClass : IStructNestedStaticClass
            where TPartialClassCollection : IPartialClassCollection
        {
            new NestedClassCollectionWrapper<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>(nestedClass).Accept(visitor);
        }

        public static void VisitStaticTypeChildren<TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticType<TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> type,
            IGenericVisitor visitor)
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            VisitIfNotNull(type.Events, visitor);
            VisitCollection(type.Properties, visitor);
            VisitIfNotNull(type.Methods, visitor);
            VisitIfNotNull(type.Fields, visitor);
            VisitIfNotNull(type.Classes, visitor);
            VisitCollection(type.Delegates, visitor);
            VisitCollection(type.Enums, visitor);
            VisitIfNotNull(type.Interfaces, visitor);
            VisitIfNotNull(type.Structs, visitor);
            VisitIfNotNull(type.StaticConstructor, visitor);
        }

        public static void VisitNestedStaticClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @class,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            VisitCollection(@class.Attributes, visitor);
            VisitCollection(@class.GenericParameters, visitor);
            new StaticTypeWrapper<TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(@class).Accept(visitor);
        }

        public static void VisitClassNestedStaticClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IClassType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            new NestedStaticClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedStaticClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStaticType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            new NestedStaticClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedStaticClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IStructType
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : INestedStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            new NestedStaticClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitClassNestedAbstractClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new NestedAbstractClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedAbstractClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new NestedAbstractClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedAbstractClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new NestedAbstractClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitAbstractClassChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new ClassWrapper<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(@class).Accept(visitor);
        }

        public static void VisitSealedClassChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(
            ISealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor> @class,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new ClassWrapper<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TDestructor, TStaticConstructor>(@class).Accept(visitor);
        }

        public static void VisitStaticClassChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(
            IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor> @class,
            IGenericVisitor visitor)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TEventCollection : IStaticClassEventCollection
            where TProperty : IStaticClassProperty
            where TMethodCollection : IStaticClassMethodCollection
            where TFieldCollection : IStaticClassFieldCollection
            where TNestedClassCollection : IStaticClassNestedClassCollection
            where TNestedDelegate : IStaticClassNestedDelegate
            where TNestedEnum : IStaticClassNestedEnum
            where TNestedInterfaceCollection : IStaticClassNestedInterfaceCollection
            where TNestedStructCollection : IStaticClassNestedStructCollection
            where TStaticConstructor : IStaticConstructor
        {
            VisitCollection(@class.Attributes, visitor);
            VisitCollection(@class.GenericParameters, visitor);
            new StaticTypeWrapper<TEventCollection, TProperty, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TStaticConstructor>(@class).Accept(visitor);
        }

        public static void VisitClassNestedSealedClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new NestedSealedClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedSealedClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new NestedSealedClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedSealedClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(
            IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor> nestedClass,
            IGenericVisitor visitor)
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
            where TNestedInterfaceCollection : IClassNestedInterfaceCollection
            where TNestedStructCollection : IClassNestedStructCollection
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
        {
            new NestedSealedClassWrapper<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterfaceCollection, TNestedStructCollection, TNestedDestructor, TStaticConstructor>(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassEventCollectionChildren<TEvent, TEventProperty>(
            IStaticClassEventCollection<TEvent, TEventProperty> eventCollection,
            IGenericVisitor visitor)
            where TEvent : IStaticClassEvent
            where TEventProperty : IStaticClassEventProperty
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
        }

        public static void VisitStaticClassMethodCollectionChildren<TMethod, TExtensionMethod>(
            IStaticClassMethodCollection<TMethod, TExtensionMethod> methodCollection,
            IGenericVisitor visitor)
            where TMethod : IStaticClassMethod
            where TExtensionMethod : IExtensionMethod
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExtensionMethods, visitor);
        }

        public static void VisitNestedStaticClassMethodCollectionChildren<TMethod>(
            INestedStaticClassMethodCollection<TMethod> methodCollection,
            IGenericVisitor visitor)
            where TMethod : IStaticClassMethod
        {
            VisitCollection(methodCollection, visitor);
        }
    }
}
