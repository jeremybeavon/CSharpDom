using CSharpDom.BaseClasses.Wrappers;
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

        public static void VisitClassChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> @class,
            IGenericVisitor visitor)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEvent : IClassEvent
            where TProperty : IClassProperty
            where TIndexer : IClassIndexer
            where TMethod : IClassMethod
            where TField : IClassField
            where TConstructor : IClassConstructor
            where TEventProperty : IClassEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IClassNestedClass
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStruct : IClassNestedStruct
            where TDestructor : IDestructor
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitIfNotNull(@class.BaseClass, visitor);
            VisitCollection(@class.ImplementedInterfaces, visitor);
            VisitCollection(@class.Attributes, visitor);
            VisitCollection(@class.GenericParameters, visitor);
            VisitTypeChildren(@class, visitor);
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
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            new ConstructorWrapper<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(constructor).Accept(visitor);
        }

        public static void VisitConstructorChildren<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TParameter : IParameter
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
            where TParameter : IParameter
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
            where TParameter : IParameter
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

        public static void VisitFieldChildren<TAttributeGroup, TDeclaringType, TTypeReference>(
            IField<TAttributeGroup, TDeclaringType, TTypeReference> field,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TTypeReference : ITypeReference
        {
            VisitCollection(field.Attributes, visitor);
            VisitIfNotNull(field.FieldType, visitor);
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
            where TParameter : IParameter
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

        public static void VisitLoadedDocumentChildren<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument,
            IGenericVisitor visitor)
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TUsingDirective : IUsingDirective
            where TAttributeGroup : IAttributeGroup
            where TNamespace : INamespace
            where TClass : IClass
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStruct : IStruct
        {
            VisitCollection(loadedDocument.UsingDirectives, visitor);
            VisitCollection(loadedDocument.AssemblyAttributes, visitor);
            VisitCollection(loadedDocument.ModuleAttributes, visitor);
            VisitCollection(loadedDocument.Namespaces, visitor);
            VisitCollection(loadedDocument.Classes, visitor);
            VisitCollection(loadedDocument.Delegates, visitor);
            VisitCollection(loadedDocument.Enums, visitor);
            VisitCollection(loadedDocument.Interfaces, visitor);
            VisitCollection(loadedDocument.Structs, visitor);
        }

        public static void VisitMethodChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> method,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IBasicType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
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
            where TParameter : IParameter
            where TMethodBody : IMethodBody
        {
            VisitCollection(method.Attributes, visitor);
            VisitCollection(method.GenericParameters, visitor);
            VisitIfNotNull(method.ReturnType, visitor);
            VisitCollection(method.Parameters, visitor);
            VisitIfNotNull(method.Body, visitor);
        }

        public static void VisitNamespaceChildren<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace,
            IGenericVisitor visitor)
            where TUsingDirective : IUsingDirective
            where TNamespace : INamespace
            where TClass : IClass
            where TDelegate : IDelegate
            where TEnum : IEnum
            where TInterface : IInterface
            where TStruct : IStruct
        {
            VisitCollection(@namespace.UsingDirectives, visitor);
            VisitCollection(@namespace.Namespaces, visitor);
            VisitCollection(@namespace.Classes, visitor);
            VisitCollection(@namespace.Delegates, visitor);
            VisitCollection(@namespace.Enums, visitor);
            VisitCollection(@namespace.Interfaces, visitor);
            VisitCollection(@namespace.Structs, visitor);
        }

        public static void VisitNestedClassChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedClass,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TClassReference : IClassReference
            where TInterfaceReference : IInterfaceReference
            where TEvent : IClassEvent
            where TProperty : IClassProperty
            where TIndexer : IClassIndexer
            where TMethod : IClassMethod
            where TField : IClassField
            where TConstructor : IClassConstructor
            where TEventProperty : IClassEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IClassNestedClass
            where TNestedDelegate : IClassNestedDelegate
            where TNestedEnum : IClassNestedEnum
            where TNestedInterface : IClassNestedInterface
            where TNestedStruct : IClassNestedStruct
            where TNestedDestructor : INestedDestructor
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitCollection(nestedClass.Attributes, visitor);
            VisitCollection(nestedClass.GenericParameters, visitor);
            VisitIfNotNull(nestedClass.BaseClass, visitor);
            VisitCollection(nestedClass.Interfaces, visitor);
        }

        public static void VisitNestedDelegateChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TTypeReference : ITypeReference
            where TParameter : IParameter
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

        public static void VisitNestedStructChildren<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> nestedStruct,
            IGenericVisitor visitor)
            where TAttributeGroup : IAttributeGroup
            where TDeclaringType : IType
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IStructEvent
            where TProperty : IStructProperty
            where TIndexer : IStructIndexer
            where TMethod : IStructMethod
            where TField : IStructField
            where TConstructor : IStructConstructor
            where TEventProperty : IStructEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IStructNestedClass
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStruct : IStructNestedStruct
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitCollection(nestedStruct.Attributes, visitor);
            VisitCollection(nestedStruct.GenericParameters, visitor);
            VisitCollection(nestedStruct.Interfaces, visitor);
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
            where TParameter : IParameter
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

        public static void VisitStructChildren<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> @struct,
            IGenericVisitor visitor)
            where TNamespace : INamespace
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup
            where TGenericParameter : IGenericParameterDeclaration
            where TInterfaceReference : IInterfaceReference
            where TEvent : IStructEvent
            where TProperty : IStructProperty
            where TIndexer : IStructIndexer
            where TMethod : IStructMethod
            where TField : IStructField
            where TConstructor : IStructConstructor
            where TEventProperty : IStructEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : IStructNestedClass
            where TNestedDelegate : IStructNestedDelegate
            where TNestedEnum : IStructNestedEnum
            where TNestedInterface : IStructNestedInterface
            where TNestedStruct : IStructNestedStruct
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
        {
            VisitCollection(@struct.Attributes, visitor);
            VisitCollection(@struct.GenericParameters, visitor);
            VisitCollection(@struct.Interfaces, visitor);
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

        public static void VisitTypeChildren<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod>(
            IType<TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TStaticConstructor, TExplicitInterfaceEvent, TExplicitInterfaceProperty, TExplicitInterfaceIndexer, TExplicitInterfaceMethod> type,
            IGenericVisitor visitor)
            where TEvent : IEvent
            where TProperty : IProperty
            where TIndexer : IIndexer
            where TMethod : IMethod
            where TField : IField
            where TConstructor : IConstructor
            where TEventProperty : IEventProperty
            where TOperatorOverload : IOperatorOverload
            where TConversionOperator : IConversionOperator
            where TNestedClass : INestedClass
            where TNestedDelegate : INestedDelegate
            where TNestedEnum : INestedEnum
            where TNestedInterface : INestedInterface
            where TNestedStruct : INestedStruct
            where TStaticConstructor : IStaticConstructor
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty
        {
            VisitCollection(type.Events, visitor);
            VisitCollection(type.Properties, visitor);
            VisitCollection(type.Indexers, visitor);
            VisitCollection(type.Methods, visitor);
            VisitCollection(type.Fields, visitor);
            VisitCollection(type.Constructors, visitor);
            VisitCollection(type.EventProperties, visitor);
            VisitCollection(type.OperatorOverloads, visitor);
            VisitCollection(type.ConversionOperators, visitor);
            VisitCollection(type.Classes, visitor);
            VisitCollection(type.Delegates, visitor);
            VisitCollection(type.Enums, visitor);
            VisitCollection(type.Interfaces, visitor);
            VisitCollection(type.Structs, visitor);
            VisitIfNotNull(type.StaticConstructor, visitor);
            VisitCollection(type.ExplicitInterfaceEvents, visitor);
            VisitCollection(type.ExplicitInterfaceProperties, visitor);
            VisitCollection(type.ExplicitInterfaceIndexers, visitor);
            VisitCollection(type.ExplicitInterfaceMethods, visitor);
        }
    }
}
