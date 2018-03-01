using CSharpDom.BaseClasses.Wrappers;
using CSharpDom.Common.Partial;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom.Common
{
    public static class GenericChildVisitor
    {
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

        public static void VisitAccessor<TAccessor, TAttributeGroup, TMethodBody, TVisitor>(
            TAccessor accessor,
            TVisitor visitor)
            where TAccessor : IAccessor<TAttributeGroup, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(accessor.Attributes, visitor);
            VisitIfNotNull(accessor.Body, visitor);
        }

        public static void VisitArrayTypeReferenceChildren<TArrayTypeReference, TTypeReference, TVisitor>(
            TArrayTypeReference arrayTypeReference,
            TVisitor visitor)
            where TArrayTypeReference : IArrayTypeReference<TTypeReference>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitIfNotNull(arrayTypeReference.ElementType, visitor);
        }

        public static void VisitAttributeGroupChildren<TAttributeGroup, TAttribute, TVisitor>(
            TAttributeGroup attributeGroup,
            TVisitor visitor)
            where TAttributeGroup : IAttributeGroup<TAttribute>
            where TAttribute : IAttribute, IVisitable<TVisitor>
        {
            VisitCollection(attributeGroup.Attributes, visitor);
        }

        public static void VisitAttributeChildren<TAttribute, TClassReference, TUnnamedAttributeValue, TNamedAttributeValue, TVisitor>(
            TAttribute attribute,
            TVisitor visitor)
            where TAttribute : IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TUnnamedAttributeValue : IUnnamedAttributeValue, IVisitable<TVisitor>
            where TNamedAttributeValue : INamedAttributeValue, IVisitable<TVisitor>
        {
            VisitIfNotNull(attribute.AttributeType, visitor);
            VisitCollection(attribute.UnnamedValues, visitor);
            VisitCollection(attribute.NamedValues, visitor);
        }

        public static void VisitClassChildren<TClass, TClassType, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClass @class,
            Func<TClass, TClassType> classTypeFactory,
            TVisitor visitor)
            where TClass : IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TClassType : IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            classTypeFactory(@class).Accept(visitor);
        }

        public static void VisitPartialClassChildren<TPartialClass, TClass, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TPartialClass @class,
            Func<TPartialClass, TClass> classFactory,
            TVisitor visitor)
            where TPartialClass : IPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TClass : IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            classFactory(@class).Accept(visitor);
        }

        public static void VisitClassTypeChildren<TClassType, TType, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClassType @class,
            Func<TClassType, TType> typeFactory,
            TVisitor visitor)
            where TClassType : IClassType<TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TType : IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            VisitIfNotNull(@class.BaseClass, visitor);
            typeFactory(@class).Accept(visitor);
            VisitIfNotNull(@class.Destructor, visitor);
        }

        public static void VisitClassReferenceChildren<TClassReference, TTypeReference, TVisitor>(
            TClassReference classReference,
            Func<TClassReference, TTypeReference> typeReferenceFactory,
            TVisitor visitor)
            where TClassReference : IClassReference<TTypeReference>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitCollection(classReference.GenericParameters, visitor);
            typeReferenceFactory(classReference).Accept(visitor);
        }

        public static void VisitClassConstructorChildren<TClassConstructor, TConstructor, TAttributeGroup, TDeclaringType, TParameter, TMethodBody, TVisitor>(
            TClassConstructor constructor,
            Func<TClassConstructor, TConstructor> constructorFactory,
            TVisitor visitor)
            where TClassConstructor : IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
            where TConstructor : IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TParameter : IConstructorParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            constructorFactory(constructor).Accept(visitor);
        }

        public static void VisitStructConstructorChildren<TStructConstructor, TConstructor, TAttributeGroup, TDeclaringType, TParameter, TMethodBody, TVisitor>(
            TStructConstructor constructor,
            Func<TStructConstructor, TConstructor> constructorFactory,
            TVisitor visitor)
            where TStructConstructor : IStructConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
            where TConstructor : IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TParameter : IConstructorParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            constructorFactory(constructor).Accept(visitor);
        }

        public static void VisitConstructorChildren<TConstructor, TAttributeGroup, TDeclaringType, TParameter, TMethodBody, TVisitor>(
            TConstructor constructor,
            TVisitor visitor)
            where TConstructor : IConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TParameter : IConstructorParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(constructor.Attributes, visitor);
            VisitCollection(constructor.Parameters, visitor);
        }

        public static void VisitConversionOperatorChildren<TConversionOperator, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TConversionOperator conversionOperator,
            TVisitor visitor)
            where TConversionOperator : IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IOperatorParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(conversionOperator.Attributes, visitor);
            VisitCollection(conversionOperator.ReturnAttributes, visitor);
            VisitIfNotNull(conversionOperator.ReturnType, visitor);
            VisitIfNotNull(conversionOperator.Parameter, visitor);
            VisitIfNotNull(conversionOperator.Body, visitor);
        }

        public static void VisitDelegateChildren<TDelegate, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TDelegate @delegate,
            TVisitor visitor)
            where TDelegate : IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IDelegateParameter, IVisitable<TVisitor>
        {
            VisitCollection(@delegate.Attributes, visitor);
            VisitCollection(@delegate.GenericParameters, visitor);
            VisitIfNotNull(@delegate.ReturnType, visitor);
            VisitCollection(@delegate.Parameters, visitor);
        }

        public static void VisitDelegateReferenceChildren<TDelegateReference, TTypeReference, TVisitor>(
            TDelegateReference delegateReference,
            TVisitor visitor)
            where TDelegateReference : IDelegateReference<TTypeReference>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitCollection(delegateReference.GenericParameters, visitor);
        }

        public static void VisitDestructor<TDestructor, TAttributeGroup, TDeclaringType, TMethodBody, TVisitor>(
            TDestructor destructor,
            TVisitor visitor)
            where TDestructor : IDestructor<TAttributeGroup, TDeclaringType, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(destructor.Attributes, visitor);
            VisitIfNotNull(destructor.Body, visitor);
        }

        public static async Task VisitDocumentChildrenAsync<TDocument, TProject, TSolution, TLoadedDocument, TVisitor>(
            TDocument document,
            TVisitor visitor)
            where TDocument : IDocument<TProject, TSolution, TLoadedDocument>
            where TProject : IProject
            where TSolution : ISolution
            where TLoadedDocument : ILoadedDocument, IVisitable<TVisitor>
        {
            (await document.LoadAsync()).Accept(visitor);
        }

        public static void VisitEnumChildren<TEnum, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember, TVisitor>(
            TEnum @enum,
            TVisitor visitor)
            where TEnum : IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TEnumMember : IEnumMember, IVisitable<TVisitor>
        {
            VisitCollection(@enum.Attributes, visitor);
            VisitCollection(@enum.EnumMembers, visitor);
        }

        public static void VisitEnumMemberChildren<TEnumMember, TAttributeGroup, TDeclaringType, TVisitor>(
            TEnumMember enumMember,
            TVisitor visitor)
            where TEnumMember : IEnumMember<TAttributeGroup, TDeclaringType>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IEnum, IVisitable<TVisitor>
        {
            VisitCollection(enumMember.Attributes, visitor);
        }

        public static void VisitClassEventChildren<TClassEvent, TEvent, TAttributeGroup, TDeclaringType, TDelegateReference, TVisitor>(
            TClassEvent @event,
            Func<TClassEvent, TEvent> eventFactory,
            TVisitor visitor)
            where TClassEvent : IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
            where TEvent : IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
        {
            eventFactory(@event).Accept(visitor);
        }

        public static void VisitInterfaceEventChildren<TInterfaceEvent, TEvent, TAttributeGroup, TDeclaringType, TDelegateReference, TVisitor>(
            TInterfaceEvent @event,
            Func<TInterfaceEvent, TEvent> eventFactory,
            TVisitor visitor)
            where TInterfaceEvent : IInterfaceEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
            where TEvent : IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IInterfaceType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
        {
            eventFactory(@event).Accept(visitor);
        }

        public static void VisitSealedClassEventChildren<TSealedClassEvent, TEvent, TAttributeGroup, TDeclaringType, TDelegateReference, TVisitor>(
            TSealedClassEvent @event,
            Func<TSealedClassEvent, TEvent> eventFactory,
            TVisitor visitor)
            where TSealedClassEvent : ISealedClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
            where TEvent : IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : ISealedType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
        {
            eventFactory(@event).Accept(visitor);
        }

        public static void VisitStaticClassEventChildren<TStaticClassEvent, TEvent, TAttributeGroup, TDeclaringType, TDelegateReference, TVisitor>(
            TStaticClassEvent @event,
            Func<TStaticClassEvent, TEvent> eventFactory,
            TVisitor visitor)
            where TStaticClassEvent : IStaticClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
            where TEvent : IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
        {
            eventFactory(@event).Accept(visitor);
        }

        public static void VisitStructEventChildren<TStructEvent, TEvent, TAttributeGroup, TDeclaringType, TDelegateReference, TVisitor>(
            TStructEvent @event,
            Func<TStructEvent, TEvent> eventFactory,
            TVisitor visitor)
            where TStructEvent : IStructEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
            where TEvent : IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
        {
            eventFactory(@event).Accept(visitor);
        }

        public static void VisitEventChildren<TEvent, TAttributeGroup, TDeclaringType, TDelegateReference, TVisitor>(
            TEvent @event,
            TVisitor visitor)
            where TEvent : IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IBasicType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
        {
            VisitCollection(@event.Attributes, visitor);
            VisitIfNotNull(@event.EventType, visitor);
        }

        public static void VisitEventPropertyChildren<TEventProperty, TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody, TVisitor>(
            TEventProperty eventProperty,
            TVisitor visitor)
            where TEventProperty : IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(eventProperty.Attributes, visitor);
            VisitIfNotNull(eventProperty.EventType, visitor);
            VisitIfNotNull(eventProperty.AddBody, visitor);
            VisitIfNotNull(eventProperty.RemoveBody, visitor);
        }

        public static void VisitFieldGroupChildren<TFieldGroup, TAttributeGroup, TDeclaringType, TTypeReference, TField, TVisitor>(
            TFieldGroup field,
            TVisitor visitor)
            where TFieldGroup : IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TField : IField, IVisitable<TVisitor>
        {
            VisitCollection(field.Attributes, visitor);
            VisitIfNotNull(field.FieldType, visitor);
            VisitCollection(field.Fields, visitor);
        }

        public static void VisitConstantGroupChildren<TConstantGroup, TAttributeGroup, TDeclaringType, TTypeReference, TConstant, TVisitor>(
            TConstantGroup field,
            TVisitor visitor)
            where TConstantGroup : IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TConstant : IConstant, IVisitable<TVisitor>
        {
            VisitCollection(field.Attributes, visitor);
            VisitIfNotNull(field.FieldType, visitor);
            VisitCollection(field.Constants, visitor);
        }

        public static void VisitGenericParameterDeclaration<TGenericParameterDeclaration, TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup, TVisitor>(
            TGenericParameterDeclaration genericParameterDeclaration,
            TVisitor visitor)
            where TGenericParameterDeclaration : IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TGenericParameterReference : IGenericParameterReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
        {
            VisitCollection(genericParameterDeclaration.Attributes, visitor);
            VisitIfNotNull(genericParameterDeclaration.BaseClassConstraint, visitor);
            VisitCollection(genericParameterDeclaration.GenericParameterConstraints, visitor);
            VisitCollection(genericParameterDeclaration.InterfaceConstraints, visitor);
        }

        public static void VisitIndexerChildren<TIndexer, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor, TVisitor>(
            TIndexer indexer,
            TVisitor visitor)
            where TIndexer : IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IBasicType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IIndexerParameter, IVisitable<TVisitor>
            where TAccessor : IAccessor, IVisitable<TVisitor>
        {
            VisitCollection(indexer.Attributes, visitor);
            VisitIfNotNull(indexer.IndexerType, visitor);
            VisitCollection(indexer.Parameters, visitor);
            VisitIfNotNull(indexer.GetAccessor, visitor);
            VisitIfNotNull(indexer.SetAccessor, visitor);
        }

        public static void VisitInterfaceChildren<TInterface, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TVisitor>(
            TInterface @interface,
            TVisitor visitor)
            where TInterface : IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEvent : IInterfaceEvent, IVisitable<TVisitor>
            where TProperty : IInterfaceProperty, IVisitable<TVisitor>
            where TIndexer : IInterfaceIndexer, IVisitable<TVisitor>
            where TMethod : IInterfaceMethod, IVisitable<TVisitor>
        {
            VisitCollection(@interface.Attributes, visitor);
            VisitCollection(@interface.GenericParameters, visitor);
            VisitCollection(@interface.Interfaces, visitor);
            VisitCollection(@interface.Events, visitor);
            VisitCollection(@interface.Properties, visitor);
            VisitCollection(@interface.Indexers, visitor);
            VisitCollection(@interface.Methods, visitor);
        }

        public static void VisitInterfaceAccessorChildren<TInterfaceAccessor, TAttributeGroup, TVisitor>(
            TInterfaceAccessor accessor,
            TVisitor visitor)
            where TInterfaceAccessor : IInterfaceAccessor<TAttributeGroup>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
        {
            VisitCollection(accessor.Attributes, visitor);
        }

        public static void VisitInterfaceReferenceChildren<TInterfaceReference, TTypeReference, TVisitor>(
            TInterfaceReference interfaceReference,
            TVisitor visitor)
            where TInterfaceReference : IInterfaceReference<TTypeReference>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitCollection(interfaceReference.GenericParameters, visitor);
        }

        public static void VisitLoadedDocumentChildren<TLoadedDocument, TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection, TVisitor>(
            TLoadedDocument loadedDocument,
            TVisitor visitor)
            where TLoadedDocument : ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
            where TSolution : ISolution
            where TProject : IProject
            where TDocument : IDocument
            where TUsingDirective : IUsingDirective, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TClassCollection : IClassCollection, IVisitable<TVisitor>
            where TDelegate : IDelegate, IVisitable<TVisitor>
            where TEnum : IEnum, IVisitable<TVisitor>
            where TInterface : IInterface, IVisitable<TVisitor>
            where TStructCollection : IStructCollection, IVisitable<TVisitor>
        {
            VisitCollection(loadedDocument.UsingDirectives, visitor);
            VisitCollection(loadedDocument.AssemblyAttributes, visitor);
            VisitCollection(loadedDocument.ModuleAttributes, visitor);
            VisitCollection(loadedDocument.Namespaces, visitor);
            VisitIfNotNull(loadedDocument.Classes, visitor);
            VisitCollection(loadedDocument.Delegates, visitor);
            VisitCollection(loadedDocument.Enums, visitor);
            VisitCollection(loadedDocument.Interfaces, visitor);
            VisitIfNotNull(loadedDocument.Structs, visitor);
        }

        public static void VisitLoadedProjectChildren<TLoadedProject, TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection, TVisitor>(
            TLoadedProject loadedProject,
            TVisitor visitor)
            where TLoadedProject : ILoadedProject<TSolution, TProject, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>
            where TSolution : ISolution
            where TProject : IProject
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TClassCollection : IClassCollection, IVisitable<TVisitor>
            where TDelegate : IDelegate, IVisitable<TVisitor>
            where TEnum : IEnum, IVisitable<TVisitor>
            where TInterface : IInterface, IVisitable<TVisitor>
            where TStructCollection : IStructCollection, IVisitable<TVisitor>
        {
            VisitCollection(loadedProject.Namespaces, visitor);
            VisitIfNotNull(loadedProject.Classes, visitor);
            VisitCollection(loadedProject.Delegates, visitor);
            VisitCollection(loadedProject.Enums, visitor);
            VisitCollection(loadedProject.Interfaces, visitor);
            VisitIfNotNull(loadedProject.Structs, visitor);
        }

        public static void VisitMethodChildren<TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TMethod method,
            TVisitor visitor)
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IBasicType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
        {
            VisitCollection(method.Attributes, visitor);
            VisitCollection(method.ReturnAttributes, visitor);
            VisitCollection(method.GenericParameters, visitor);
            VisitIfNotNull(method.ReturnType, visitor);
            VisitCollection(method.Parameters, visitor);
        }

        public static void VisitMethodChildren<TMethodWithBody, TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TMethodWithBody method,
            Func<TMethodWithBody, TMethod> methodFactory,
            TVisitor visitor)
            where TMethodWithBody : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            methodFactory(method).Accept(visitor);
            VisitIfNotNull(method.Body, visitor);
        }

        public static void VisitPartialMethodDefinitionChildren<TPartialMethodDefinition, TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TVisitor>(
            TPartialMethodDefinition method,
            TVisitor visitor)
            where TPartialMethodDefinition : IPartialMethodDefinition<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
        {
            VisitCollection(method.Attributes, visitor);
            VisitCollection(method.ReturnAttributes, visitor);
            VisitCollection(method.GenericParameters, visitor);
            VisitCollection(method.Parameters, visitor);
        }

        public static void VisitPartialMethodImplementationChildren<TPartialMethodImplementation, TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody, TVisitor>(
            TPartialMethodImplementation method,
            TVisitor visitor)
            where TPartialMethodImplementation : IPartialMethodImplementation<TAttributeGroup, TDeclaringType, TGenericParameter, TParameter, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(method.Attributes, visitor);
            VisitCollection(method.ReturnAttributes, visitor);
            VisitCollection(method.GenericParameters, visitor);
            VisitCollection(method.Parameters, visitor);
            VisitIfNotNull(method.Body, visitor);
        }

        public static void VisitClassMethodChildren<TClassMethod, TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TClassMethod method,
            Func<TClassMethod, TMethod> methodFactory,
            TVisitor visitor)
            where TClassMethod : IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            methodFactory(method).Accept(visitor);
        }

        public static void VisitAbstractMethodChildren<TAbstractMethod, TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TAbstractMethod method,
            Func<TAbstractMethod, TMethod> methodFactory,
            TVisitor visitor)
            where TAbstractMethod : IAbstractMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IAbstractType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
        {
            methodFactory(method).Accept(visitor);
        }

        public static void VisitInterfaceMethodChildren<TInterfaceMethod, TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TInterfaceMethod method,
            Func<TInterfaceMethod, TMethod> methodFactory,
            TVisitor visitor)
            where TInterfaceMethod : IInterfaceMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IInterfaceType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
        {
            methodFactory(method).Accept(visitor);
        }

        public static void VisitSealedClassMethodChildren<TSealedClassMethod, TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TSealedClassMethod method,
            Func<TSealedClassMethod, TMethod> methodFactory,
            TVisitor visitor)
            where TSealedClassMethod : ISealedClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : ISealedType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            methodFactory(method).Accept(visitor);
        }

        public static void VisitStaticClassMethodChildren<TStaticClassMethod, TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TStaticClassMethod method,
            Func<TStaticClassMethod, TMethod> methodFactory,
            TVisitor visitor)
            where TStaticClassMethod : IStaticClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            methodFactory(method).Accept(visitor);
        }

        public static void VisitStructMethodChildren<TStructMethod, TMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TStructMethod method,
            Func<TStructMethod, TMethod> methodFactory,
            TVisitor visitor)
            where TStructMethod : IStructMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            methodFactory(method).Accept(visitor);
        }

        public static void VisitNamespaceChildren<TNamespace, TUsingDirective, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection, TVisitor>(
            TNamespace @namespace,
            TVisitor visitor)
            where TNamespace : INamespace<TUsingDirective, TNamespace, TClassCollection, TDelegate, TEnum, TInterface, TStructCollection>, IVisitable<TVisitor>
            where TUsingDirective : IUsingDirective, IVisitable<TVisitor>
            where TClassCollection : IClassCollection, IVisitable<TVisitor>
            where TDelegate : IDelegate, IVisitable<TVisitor>
            where TEnum : IEnum, IVisitable<TVisitor>
            where TInterface : IInterface, IVisitable<TVisitor>
            where TStructCollection : IStructCollection, IVisitable<TVisitor>
        {
            VisitCollection(@namespace.UsingDirectives, visitor);
            VisitCollection(@namespace.Namespaces, visitor);
            VisitIfNotNull(@namespace.Classes, visitor);
            VisitCollection(@namespace.Delegates, visitor);
            VisitCollection(@namespace.Enums, visitor);
            VisitCollection(@namespace.Interfaces, visitor);
            VisitIfNotNull(@namespace.Structs, visitor);
        }

        public static void VisitNestedClassChildren<TNestedClass, TType, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TNestedClass nestedClass,
            Func<TNestedClass, TType> typeFactory,
            TVisitor visitor)
            where TNestedClass : INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TType : IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            VisitIfNotNull(nestedClass.BaseClass, visitor);
            typeFactory(nestedClass).Accept(visitor);
        }

        public static void VisitNestedDelegateChildren<TNestedDelegate, TDelegateType, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TNestedDelegate nestedDelegate,
            Func<TNestedDelegate, TDelegateType> delegateTypeFactory,
            TVisitor visitor)
            where TNestedDelegate : INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
            where TDelegateType : IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IDelegateParameter, IVisitable<TVisitor>
        {
            delegateTypeFactory(nestedDelegate).Accept(visitor);
        }

        public static void VisitDelegateTypeChildren<TDelegateType, TAttributeGroup, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TDelegateType @delegate,
            TVisitor visitor)
            where TDelegateType : IDelegateType<TAttributeGroup, TGenericParameter, TTypeReference, TParameter>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IDelegateParameter, IVisitable<TVisitor>
        {
            VisitCollection(@delegate.Attributes, visitor);
            VisitCollection(@delegate.GenericParameters, visitor);
            VisitIfNotNull(@delegate.ReturnType, visitor);
            VisitCollection(@delegate.Parameters, visitor);
        }

        public static void VisiTDestructorChildren<TDestructor, TAttributeGroup, TDeclaringType, TMethodBody, TVisitor>(
            TDestructor nestedDestructor,
            TVisitor visitor)
            where TDestructor : IDestructor<TAttributeGroup, TDeclaringType, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : INestedClass, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(nestedDestructor.Attributes, visitor);
            VisitIfNotNull(nestedDestructor.Body, visitor);
        }

        public static void VisitNestedEnumChildren<TNestedEnum, TAttributeGroup, TDeclaringType, TNestedEnumMember, TVisitor>(
            TNestedEnum nestedEnum,
            TVisitor visitor)
            where TNestedEnum : INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TNestedEnumMember : INestedEnumMember, IVisitable<TVisitor>
        {
            VisitCollection(nestedEnum.Attributes, visitor);
            VisitCollection(nestedEnum.EnumMembers, visitor);
        }

        public static void VisitNestedEnumMemberChildren<TNestedEnumMember, TAttributeGroup, TDeclaringType, TVisitor>(
            TNestedEnumMember nestedEnumMember,
            TVisitor visitor)
            where TNestedEnumMember : INestedEnumMember<TAttributeGroup, TDeclaringType>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : INestedEnum, IVisitable<TVisitor>
        {
            VisitCollection(nestedEnumMember.Attributes, visitor);
        }

        public static void VisitNestedInterfaceChildren<TNestedInterface, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TVisitor>(
            TNestedInterface @interface,
            TVisitor visitor)
            where TNestedInterface : INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEvent : IInterfaceEvent, IVisitable<TVisitor>
            where TProperty : IInterfaceProperty, IVisitable<TVisitor>
            where TIndexer : IInterfaceIndexer, IVisitable<TVisitor>
            where TMethod : IInterfaceMethod, IVisitable<TVisitor>
        {
            VisitCollection(@interface.Interfaces, visitor);
            VisitCollection(@interface.Events, visitor);
            VisitCollection(@interface.Properties, visitor);
            VisitCollection(@interface.Indexers, visitor);
            VisitCollection(@interface.Methods, visitor);
        }

        public static void VisitNestedStructChildren<TNestedStruct, TStructType, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TNestedStruct nestedStruct,
            Func<TNestedStruct, TStructType> structTypeFactory,
            TVisitor visitor)
            where TNestedStruct : INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStructType : IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            structTypeFactory(nestedStruct).Accept(visitor);
        }

        public static void VisitNestedTypeReferenceChildren<TNestedTypeReference, TTypeReference, TVisitor>(
            TNestedTypeReference nestedTypeReference,
            TVisitor visitor)
            where TNestedTypeReference : INestedTypeReference<TTypeReference>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitIfNotNull(nestedTypeReference.Type, visitor);
            VisitIfNotNull(nestedTypeReference.NestedType, visitor);
        }

        public static void VisitNullableTypeReference<TNullableTypeReference, TStructReference, TVisitor>(
            TNullableTypeReference reference,
            TVisitor visitor)
            where TNullableTypeReference : INullableTypeReference<TStructReference>
            where TStructReference : IStructReference, IVisitable<TVisitor>
        {
            VisitIfNotNull(reference.Type, visitor);
        }

        public static void VisitOperatorOverloadChildren<TOperatorOverload, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TOperatorOverload operatorOverload,
            TVisitor visitor)
            where TOperatorOverload : IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IOperatorParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(operatorOverload.Attributes, visitor);
            VisitIfNotNull(operatorOverload.ReturnType, visitor);
            VisitCollection(operatorOverload.Parameters, visitor);
            VisitIfNotNull(operatorOverload.Body, visitor);
        }

        public static void VisitParameterChildren<TParameter, TAttributeGroup, TTypeReference, TVisitor>(
            TParameter parameter,
            TVisitor visitor)
            where TParameter : IParameter<TAttributeGroup, TTypeReference>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitCollection(parameter.Attributes, visitor);
            VisitIfNotNull(parameter.ParameterType, visitor);
        }

        public static void VisitConstructorParameterChildren<TConstructorParameter, TParameter, TAttributeGroup, TTypeReference, TVisitor>(
            TConstructorParameter parameter,
            Func<TConstructorParameter, TParameter> parameterFactory,
            TVisitor visitor)
            where TConstructorParameter : IConstructorParameter<TAttributeGroup, TTypeReference>
            where TParameter : IParameter<TAttributeGroup, TTypeReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            parameterFactory(parameter).Accept(visitor);
        }

        public static void VisitDelegateParameterChildren<TDelegateParameter, TParameter, TAttributeGroup, TTypeReference, TVisitor>(
            TDelegateParameter parameter,
            Func<TDelegateParameter, TParameter> parameterFactory,
            TVisitor visitor)
            where TDelegateParameter : IDelegateParameter<TAttributeGroup, TTypeReference>
            where TParameter : IParameter<TAttributeGroup, TTypeReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            parameterFactory(parameter).Accept(visitor);
        }

        public static void VisitExtensionParameterChildren<TExtensionParameter, TParameter, TAttributeGroup, TTypeReference, TVisitor>(
            TExtensionParameter parameter,
            Func<TExtensionParameter, TParameter> parameterFactory,
            TVisitor visitor)
            where TExtensionParameter : IExtensionParameter<TAttributeGroup, TTypeReference>
            where TParameter : IParameter<TAttributeGroup, TTypeReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            parameterFactory(parameter).Accept(visitor);
        }

        public static void VisitIndexerParameterChildren<TIndexerParameter, TParameter, TAttributeGroup, TTypeReference, TVisitor>(
            TIndexerParameter parameter,
            Func<TIndexerParameter, TParameter> parameterFactory,
            TVisitor visitor)
            where TIndexerParameter : IIndexerParameter<TAttributeGroup, TTypeReference>
            where TParameter : IParameter<TAttributeGroup, TTypeReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            parameterFactory(parameter).Accept(visitor);
        }

        public static void VisitMethodParameterChildren<TMethodParameter, TParameter, TAttributeGroup, TTypeReference, TVisitor>(
            TMethodParameter parameter,
            Func<TMethodParameter, TParameter> parameterFactory,
            TVisitor visitor)
            where TMethodParameter : IMethodParameter<TAttributeGroup, TTypeReference>
            where TParameter : IParameter<TAttributeGroup, TTypeReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            parameterFactory(parameter).Accept(visitor);
        }

        public static void VisitOperatorParameterChildren<TOperatorParameter, TParameter, TAttributeGroup, TTypeReference, TVisitor>(
            TOperatorParameter parameter,
            Func<TOperatorParameter, TParameter> parameterFactory,
            TVisitor visitor)
            where TOperatorParameter : IOperatorParameter<TAttributeGroup, TTypeReference>
            where TParameter : IParameter<TAttributeGroup, TTypeReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            parameterFactory(parameter).Accept(visitor);
        }

        public static Task VisitProjectChildrenAsync<TProject, TSolution, TDocument, TLoadedProject, TVisitor>(
            TProject project,
            TVisitor visitor)
            where TProject : IProject<TSolution, TDocument, TLoadedProject>
            where TSolution : ISolution
            where TDocument : IDocument, IAsyncVisitable<TVisitor>
            where TLoadedProject : ILoadedProject
        {
            return VisitCollectionAsync(project.Documents, visitor);
        }

        public static void VisitPropertyChildren<TProperty, TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TVisitor>(
            TProperty property,
            TVisitor visitor)
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IBasicType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IAccessor, IVisitable<TVisitor>
        {
            VisitCollection(property.Attributes, visitor);
            VisitIfNotNull(property.GetAccessor, visitor);
            VisitIfNotNull(property.SetAccessor, visitor);
        }

        public static async Task VisitSolutionChildrenAsync<TSolution, TProject, TVisitor>(TSolution solution, TVisitor visitor)
            where TSolution : ISolution<TProject>
            where TProject : IProject, IAsyncVisitable<TVisitor>
        {
            await VisitCollectionAsync(solution.Projects, visitor);
        }

        public static void VisitStaticConstructorChildren<TStaticConstructor, TAttributeGroup, TDeclaringType, TMethodBody, TVisitor>(
            TStaticConstructor staticConstructor,
            TVisitor visitor)
            where TStaticConstructor : IStaticConstructor<TAttributeGroup, TDeclaringType, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitCollection(staticConstructor.Attributes, visitor);
            VisitIfNotNull(staticConstructor.Body, visitor);
        }

        public static void VisitStructChildren<TStruct, TStructType, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStruct @struct,
            Func<TStruct, TStructType> structTypeFactory,
            TVisitor visitor)
            where TStruct : IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TStructType : IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            VisitCollection(@struct.Attributes, visitor);
            VisitCollection(@struct.GenericParameters, visitor);
            VisitCollection(@struct.ImplementedInterfaces, visitor);
            structTypeFactory(@struct).Accept(visitor);
        }

        public static void VisitPartialStructChildren<TPartialStruct, TStruct, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TPartialStruct @struct,
            Func<TPartialStruct, TStruct> structFactory,
            TVisitor visitor)
            where TPartialStruct : IPartialStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStruct : IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            structFactory(@struct).Accept(visitor);
        }

        public static void VisitStructReferenceChildren<TStructReference, TTypeReference, TVisitor>(
            TStructReference structReference,
            TVisitor visitor)
            where TStructReference : IStructReference<TTypeReference>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitCollection(structReference.GenericParameters, visitor);
        }

        public static void VisitUnspecifiedTypeReference<TUnspecifiedTypeReference, TTypeReference, TVisitor>(
            TUnspecifiedTypeReference unspecificTypeReference,
            TVisitor visitor)
            where TUnspecifiedTypeReference : IUnspecifiedTypeReference<TTypeReference>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
        {
            VisitCollection(unspecificTypeReference.GenericParameters, visitor);
        }

        public static void VisitTypeChildren<TType, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TType type,
            TVisitor visitor)
            where TType : IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IFieldCollection, IVisitable<TVisitor>
            where TConstructor : IConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : INestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : INestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : INestedEnum, IVisitable<TVisitor>
            where TNestedInterface : INestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : INestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            VisitCollection(type.Attributes, visitor);
            VisitCollection(type.GenericParameters, visitor);
            VisitCollection(type.ImplementedInterfaces, visitor);
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
            VisitCollection(type.Interfaces, visitor);
            VisitIfNotNull(type.Structs, visitor);
            VisitIfNotNull(type.StaticConstructor, visitor);
        }

        public static void VisitStructTypeChildren<TStructType, TType, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStructType type,
            Func<TStructType, TType> typeFactory,
            TVisitor visitor)
            where TStructType : IStructType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TType : IType<TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            typeFactory(type).Accept(visitor);
        }

        public static void VisitAbstractClassEventCollectionChildren<TAbstractClassEventCollection, TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent, TVisitor>(
            TAbstractClassEventCollection eventCollection,
            TVisitor visitor)
            where TAbstractClassEventCollection : IAbstractClassEventCollection<TEvent, TEventProperty, TAbstractEvent, TExplicitInterfaceEvent>
            where TEvent : IClassEvent, IVisitable<TVisitor>
            where TEventProperty : IClassEventProperty, IVisitable<TVisitor>
            where TAbstractEvent : IAbstractEvent, IVisitable<TVisitor>
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent, IVisitable<TVisitor>
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.AbstractEvents, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitAbstractClassIndexerCollectionChildren<TAbstractClassIndexerCollection, TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer, TVisitor>(
            TAbstractClassIndexerCollection indexerCollection,
            TVisitor visitor)
            where TAbstractClassIndexerCollection : IAbstractClassIndexerCollection<TIndexer, TAbstractIndexer, TExplicitInterfaceIndexer>
            where TIndexer : IClassIndexer, IVisitable<TVisitor>
            where TAbstractIndexer : IAbstractIndexer, IVisitable<TVisitor>
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer, IVisitable<TVisitor>
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.AbstractIndexers, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitAbstractClassMethodCollectionChildren<TAbstractClassMethodCollection, TMethod, TAbstractMethod, TExplicitInterfaceMethod, TVisitor>(
            TAbstractClassMethodCollection methodCollection,
            TVisitor visitor)
            where TAbstractClassMethodCollection : IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>
            where TMethod : IClassMethod, IVisitable<TVisitor>
            where TAbstractMethod : IAbstractMethod, IVisitable<TVisitor>
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod, IVisitable<TVisitor>
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.AbstractMethods, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitAbstractPartialClassMethodCollectionChildren<TAbstractPartialClassMethodCollection, TAbstractClassMethodCollection, TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation, TVisitor>(
            TAbstractPartialClassMethodCollection methodCollection,
            Func<TAbstractPartialClassMethodCollection, TAbstractClassMethodCollection> abstractClassMethodCollectionFactory,
            TVisitor visitor)
            where TAbstractPartialClassMethodCollection : IAbstractPartialClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
            where TAbstractClassMethodCollection : IAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>, IVisitable<TVisitor>
            where TMethod : IClassMethod, IVisitable<TVisitor>
            where TAbstractMethod : IAbstractMethod, IVisitable<TVisitor>
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod, IVisitable<TVisitor>
            where TPartialMethodDefinition : IPartialMethodDefinition, IVisitable<TVisitor>
            where TPartialMethodImplementation : IPartialMethodImplementation, IVisitable<TVisitor>
        {
            abstractClassMethodCollectionFactory(methodCollection).Accept(visitor);
            VisitCollection(methodCollection.PartialMethodDefinitions, visitor);
            VisitCollection(methodCollection.PartialMethodImplementations, visitor);
        }

        public static void VisitAbstractClassPropertyCollectionChildren<TAbstractClassPropertyCollection, TProperty, TAbstractProperty, TExplicitInterfaceProperty, TVisitor>(
            TAbstractClassPropertyCollection propertyCollection,
            TVisitor visitor)
            where TAbstractClassPropertyCollection : IAbstractClassPropertyCollection<TProperty, TAbstractProperty, TExplicitInterfaceProperty>
            where TProperty : IClassProperty, IVisitable<TVisitor>
            where TAbstractProperty : IAbstractProperty, IVisitable<TVisitor>
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty, IVisitable<TVisitor>
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.AbstractProperties, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitClassEventCollectionChildren<TClassEventCollection, TEvent, TEventProperty, TExplicitInterfaceEvent, TVisitor>(
            TClassEventCollection eventCollection,
            TVisitor visitor)
            where TClassEventCollection : IClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
            where TEvent : IClassEvent, IVisitable<TVisitor>
            where TEventProperty : IClassEventProperty, IVisitable<TVisitor>
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent, IVisitable<TVisitor>
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitClassIndexerCollectionChildren<TClassIndexerCollection, TIndexer, TExplicitInterfaceIndexer, TVisitor>(
            TClassIndexerCollection indexerCollection,
            TVisitor visitor)
            where TClassIndexerCollection : IClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
            where TIndexer : IClassIndexer, IVisitable<TVisitor>
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer, IVisitable<TVisitor>
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitClassMethodCollectionChildren<TClassMethodCollection, TMethod, TExplicitInterfaceMethod, TVisitor>(
            TClassMethodCollection methodCollection,
            TVisitor visitor)
            where TClassMethodCollection : IClassMethodCollection<TMethod, TExplicitInterfaceMethod>
            where TMethod : IClassMethod, IVisitable<TVisitor>
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod, IVisitable<TVisitor>
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitClassPropertyCollectionChildren<TClassPropertyCollection, TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty, TVisitor>(
            TClassPropertyCollection propertyCollection,
            TVisitor visitor)
            where TClassPropertyCollection : IClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
            where TProperty : IClassProperty, IVisitable<TVisitor>
            where TAutoProperty : IClassAutoProperty, IVisitable<TVisitor>
            where TLambdaProperty : IClassLambdaProperty, IVisitable<TVisitor>
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty, IVisitable<TVisitor>
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitSealedClassEventCollectionChildren<TSealedClassEventCollection, TEvent, TEventProperty, TExplicitInterfaceEvent, TVisitor>(
            TSealedClassEventCollection eventCollection,
            TVisitor visitor)
            where TSealedClassEventCollection : ISealedClassEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
            where TEvent : ISealedClassEvent, IVisitable<TVisitor>
            where TEventProperty : ISealedClassEventProperty, IVisitable<TVisitor>
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent, IVisitable<TVisitor>
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitSealedClassIndexerCollectionChildren<TSealedClassIndexerCollection, TIndexer, TExplicitInterfaceIndexer, TVisitor>(
            TSealedClassIndexerCollection indexerCollection,
            TVisitor visitor)
            where TSealedClassIndexerCollection : ISealedClassIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
            where TIndexer : ISealedClassIndexer, IVisitable<TVisitor>
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer, IVisitable<TVisitor>
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitSealedClassMethodCollectionChildren<TSealedClassMethodCollection, TMethod, TExplicitInterfaceMethod, TVisitor>(
            TSealedClassMethodCollection methodCollection,
            TVisitor visitor)
            where TSealedClassMethodCollection : ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>
            where TMethod : ISealedClassMethod, IVisitable<TVisitor>
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod, IVisitable<TVisitor>
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitSealedPartialClassMethodCollectionChildren<TSealedPartialClassMethodCollection, TSealedClassMethodCollection, TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation, TVisitor>(
            TSealedPartialClassMethodCollection methodCollection,
            Func<TSealedPartialClassMethodCollection, TSealedClassMethodCollection> sealedClassMethodCollectionFactory,
            TVisitor visitor)
            where TSealedPartialClassMethodCollection : ISealedPartialClassMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
            where TSealedClassMethodCollection : ISealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>, IVisitable<TVisitor>
            where TMethod : ISealedClassMethod, IVisitable<TVisitor>
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod, IVisitable<TVisitor>
            where TPartialMethodDefinition : IPartialMethodDefinition, IVisitable<TVisitor>
            where TPartialMethodImplementation : IPartialMethodImplementation, IVisitable<TVisitor>
        {
            sealedClassMethodCollectionFactory(methodCollection).Accept(visitor);
            VisitCollection(methodCollection.PartialMethodDefinitions, visitor);
            VisitCollection(methodCollection.PartialMethodImplementations, visitor);
        }

        public static void VisitSealedClassPropertyCollectionChildren<TSealedClassPropertyCollection, TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty, TVisitor>(
            TSealedClassPropertyCollection propertyCollection,
            TVisitor visitor)
            where TSealedClassPropertyCollection : ISealedClassPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
            where TProperty : ISealedClassProperty, IVisitable<TVisitor>
            where TAutoProperty : ISealedClassAutoProperty, IVisitable<TVisitor>
            where TLambdaProperty : ISealedClassLambdaProperty, IVisitable<TVisitor>
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty, IVisitable<TVisitor>
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitStructEventCollectionChildren<TStructEventCollection, TEvent, TEventProperty, TExplicitInterfaceEvent, TVisitor>(
            TStructEventCollection eventCollection,
            TVisitor visitor)
            where TStructEventCollection : IStructEventCollection<TEvent, TEventProperty, TExplicitInterfaceEvent>
            where TEvent : IStructEvent, IVisitable<TVisitor>
            where TEventProperty : IStructEventProperty, IVisitable<TVisitor>
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent, IVisitable<TVisitor>
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
            VisitCollection(eventCollection.ExplicitInterfaceEvents, visitor);
        }

        public static void VisitStructIndexerCollectionChildren<TStructIndexerCollection, TIndexer, TExplicitInterfaceIndexer, TVisitor>(
            TStructIndexerCollection indexerCollection,
            TVisitor visitor)
            where TStructIndexerCollection : IStructIndexerCollection<TIndexer, TExplicitInterfaceIndexer>
            where TIndexer : IStructIndexer, IVisitable<TVisitor>
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer, IVisitable<TVisitor>
        {
            VisitCollection(indexerCollection, visitor);
            VisitCollection(indexerCollection.ExplicitInterfaceIndexers, visitor);
        }

        public static void VisitStructMethodCollectionChildren<TStructMethodCollection, TMethod, TExplicitInterfaceMethod, TVisitor>(
            TStructMethodCollection methodCollection,
            TVisitor visitor)
            where TStructMethodCollection : IStructMethodCollection<TMethod, TExplicitInterfaceMethod>
            where TMethod : IStructMethod, IVisitable<TVisitor>
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod, IVisitable<TVisitor>
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExplicitInterfaceMethods, visitor);
        }

        public static void VisitPartialStructMethodCollectionChildren<TPartialStructMethodCollection, TStructMethodCollection, TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation, TVisitor>(
            TPartialStructMethodCollection methodCollection,
            Func<TPartialStructMethodCollection, TStructMethodCollection> structMethodCollectionFactory,
            TVisitor visitor)
            where TPartialStructMethodCollection : IPartialStructMethodCollection<TMethod, TExplicitInterfaceMethod, TPartialMethodDefinition, TPartialMethodImplementation>
            where TStructMethodCollection : IStructMethodCollection<TMethod, TExplicitInterfaceMethod>, IVisitable<TVisitor>
            where TMethod : IStructMethod, IVisitable<TVisitor>
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod, IVisitable<TVisitor>
            where TPartialMethodDefinition : IPartialMethodDefinition, IVisitable<TVisitor>
            where TPartialMethodImplementation : IPartialMethodImplementation, IVisitable<TVisitor>
        {
            structMethodCollectionFactory(methodCollection).Accept(visitor);
            VisitCollection(methodCollection.PartialMethodDefinitions, visitor);
            VisitCollection(methodCollection.PartialMethodImplementations, visitor);
        }

        public static void VisitStructPropertyCollectionChildren<TStructPropertyCollection, TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty, TVisitor>(
            TStructPropertyCollection propertyCollection,
            TVisitor visitor)
            where TStructPropertyCollection : IStructPropertyCollection<TProperty, TAutoProperty, TLambdaProperty, TExplicitInterfaceProperty>
            where TProperty : IStructProperty, IVisitable<TVisitor>
            where TAutoProperty : IStructAutoProperty, IVisitable<TVisitor>
            where TLambdaProperty : IStructLambdaProperty, IVisitable<TVisitor>
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty, IVisitable<TVisitor>
        {
            VisitCollection(propertyCollection, visitor);
            VisitCollection(propertyCollection.ExplicitInterfaceProperties, visitor);
        }

        public static void VisitClassFieldChildren<TClassField, TFieldGroup, TAttributeGroup, TDeclaringType, TTypeReference, TField, TVisitor>(
            TClassField field,
            Func<TClassField, TFieldGroup> fieldGroupFactory,
            TVisitor visitor)
            where TClassField : IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
            where TFieldGroup : IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TField : IField, IVisitable<TVisitor>
        {
            fieldGroupFactory(field).Accept(visitor);
        }

        public static void VisitStaticClassFieldChildren<TStaticClassField, TFieldGroup, TAttributeGroup, TDeclaringType, TTypeReference, TField, TVisitor>(
            TStaticClassField field,
            Func<TStaticClassField, TFieldGroup> fieldGroupFactory,
            TVisitor visitor)
            where TStaticClassField : IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
            where TFieldGroup : IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TField : IField, IVisitable<TVisitor>
        {
            fieldGroupFactory(field).Accept(visitor);
        }

        public static void VisitClassConstantChildren<TClassConstant, TConstantGroup, TAttributeGroup, TDeclaringType, TTypeReference, TConstant, TVisitor>(
            TClassConstant classConstant,
            Func<TClassConstant, TConstantGroup> constantGroupFactory,
            TVisitor visitor)
            where TClassConstant : IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
            where TConstantGroup : IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TConstant : IConstant, IVisitable<TVisitor>
        {
            constantGroupFactory(classConstant).Accept(visitor);
        }

        public static void VisitStaticClassConstantChildren<TStaticClassConstant, TConstantGroup, TAttributeGroup, TDeclaringType, TTypeReference, TConstant, TVisitor>(
            TStaticClassConstant classConstant,
            Func<TStaticClassConstant, TConstantGroup> constantGroupFactory,
            TVisitor visitor)
            where TStaticClassConstant : IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
            where TConstantGroup : IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TConstant : IConstant, IVisitable<TVisitor>
        {
            constantGroupFactory(classConstant).Accept(visitor);
        }

        public static void VisitClassFieldCollectionChildren<TClassFieldCollection, TField, TConstant, TVisitor>(
            TClassFieldCollection fieldCollection,
            TVisitor visitor)
            where TClassFieldCollection : IClassFieldCollection<TField, TConstant>
            where TField : IClassField, IVisitable<TVisitor>
            where TConstant : IClassConstant, IVisitable<TVisitor>
        {
            VisitCollection(fieldCollection, visitor);
            VisitCollection(fieldCollection.Constants, visitor);
        }

        public static void VisitStructFieldCollectionChildren<TStructFieldCollection, TField, TConstant, TVisitor>(
            TStructFieldCollection fieldCollection,
            TVisitor visitor)
            where TStructFieldCollection : IStructFieldCollection<TField, TConstant>
            where TField : IStructField, IVisitable<TVisitor>
            where TConstant : IStructConstant, IVisitable<TVisitor>
        {
            VisitCollection(fieldCollection, visitor);
            VisitCollection(fieldCollection.Constants, visitor);
        }

        public static void VisitStaticClassFieldCollectionChildren<TStaticClassFieldCollection, TField, TConstant, TVisitor>(
            TStaticClassFieldCollection fieldCollection,
            TVisitor visitor)
            where TStaticClassFieldCollection : IStaticClassFieldCollection<TField, TConstant>
            where TField : IStaticClassField, IVisitable<TVisitor>
            where TConstant : IStaticClassConstant, IVisitable<TVisitor>
        {
            VisitCollection(fieldCollection, visitor);
            VisitCollection(fieldCollection.Constants, visitor);
        }

        public static void VisitStructFieldChildren<TStructField, TFieldGroup, TAttributeGroup, TDeclaringType, TTypeReference, TField, TVisitor>(
            TStructField field,
            Func<TStructField, TFieldGroup> fieldGroupFactory,
            TVisitor visitor)
            where TStructField : IStructField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
            where TFieldGroup : IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TField : IField, IVisitable<TVisitor>
        {
            fieldGroupFactory(field).Accept(visitor);
        }

        public static void VisitStructConstantChildren<TStructConstant, TConstantGroup, TAttributeGroup, TDeclaringType, TTypeReference, TConstant, TVisitor>(
            TStructConstant constant,
            Func<TStructConstant, TConstantGroup> constantGroupFactory,
            TVisitor visitor)
            where TStructConstant : IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>
            where TConstantGroup : IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TConstant : IConstant, IVisitable<TVisitor>
        {
            constantGroupFactory(constant).Accept(visitor);
        }

        public static void VisitClassCollectionChildren<TClassCollection, TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection, TVisitor>(
            TClassCollection classCollection,
            TVisitor visitor)
            where TClassCollection : IClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
            where TClass : IClass, IVisitable<TVisitor>
            where TAbstractClass : IAbstractClass, IVisitable<TVisitor>
            where TSealedClass : ISealedClass, IVisitable<TVisitor>
            where TStaticClass : IStaticClass, IVisitable<TVisitor>
            where TPartialClassCollection : IPartialClassCollection, IVisitable<TVisitor>
        {
            VisitCollection(classCollection, visitor);
            VisitCollection(classCollection.AbstractClasses, visitor);
            VisitCollection(classCollection.SealedClasses, visitor);
            VisitCollection(classCollection.StaticClasses, visitor);
            VisitIfNotNull(classCollection.PartialClasses, visitor);
        }

        public static void VisitStructCollectionChildren<TStructCollection, TStruct, TPartialStruct, TVisitor>(
            TStructCollection structCollection,
            TVisitor visitor)
            where TStructCollection : IStructCollection<TStruct, TPartialStruct>
            where TStruct : IStruct, IVisitable<TVisitor>
            where TPartialStruct : IPartialStruct, IVisitable<TVisitor>
        {
            VisitCollection(structCollection, visitor);
            VisitCollection(structCollection.PartialStructs, visitor);
        }

        public static void VisitAbstractAccessorChildren<TAbstractAccessor, TAttributeGroup, TVisitor>(
            TAbstractAccessor accessor,
            TVisitor visitor)
            where TAbstractAccessor : IAbstractAccessor<TAttributeGroup>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
        {
            VisitCollection(accessor.Attributes, visitor);
        }

        public static void VisitAbstractEventChildren<TAbstractEvent, TEvent, TAttributeGroup, TDeclaringType, TDelegateReference, TVisitor>(
            TAbstractEvent @event,
            Func<TAbstractEvent, TEvent> eventFactory,
            TVisitor visitor)
            where TAbstractEvent : IAbstractEvent<TAttributeGroup, TDeclaringType, TDelegateReference>
            where TEvent : IEvent<TAttributeGroup, TDeclaringType, TDelegateReference>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IAbstractType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
        {
            eventFactory(@event).Accept(visitor);
        }

        public static void VisitAbstractIndexerChildren<TAbstractIndexer, TIndexer, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor, TVisitor>(
            TAbstractIndexer indexer,
            Func<TAbstractIndexer, TIndexer> indexerFactory,
            TVisitor visitor)
            where TAbstractIndexer : IAbstractIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
            where TIndexer : IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IAbstractType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IIndexerParameter, IVisitable<TVisitor>
            where TAccessor : IAbstractAccessor, IVisitable<TVisitor>
        {
            indexerFactory(indexer).Accept(visitor);
        }

        public static void VisitAbstractPropertyChildren<TAbstractProperty, TProperty, TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TVisitor>(
            TAbstractProperty property,
            Func<TAbstractProperty, TProperty> propertyFactory,
            TVisitor visitor)
            where TAbstractProperty : IAbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IAbstractType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IAbstractAccessor, IVisitable<TVisitor>
        {
            propertyFactory(property).Accept(visitor);
        }

        public static void VisitClassPropertyChildren<TClassProperty, TProperty, TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TVisitor>(
            TClassProperty property,
            Func<TClassProperty, TProperty> propertyFactory,
            TVisitor visitor)
            where TClassProperty : IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IClassAccessor, IVisitable<TVisitor>
        {
            propertyFactory(property).Accept(visitor);
        }

        public static void VisitInterfacePropertyChildren<TInterfaceProperty, TProperty, TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TVisitor>(
            TInterfaceProperty property,
            Func<TInterfaceProperty, TProperty> propertyFactory,
            TVisitor visitor)
            where TInterfaceProperty : IInterfaceProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IInterfaceType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IInterfaceAccessor, IVisitable<TVisitor>
        {
            propertyFactory(property).Accept(visitor);
        }

        public static void VisitSealedClassPropertyChildren<TSealedClassProperty, TProperty, TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TVisitor>(
            TSealedClassProperty property,
            Func<TSealedClassProperty, TProperty> propertyFactory,
            TVisitor visitor)
            where TSealedClassProperty : ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : ISealedType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IClassAccessor, IVisitable<TVisitor>
        {
            propertyFactory(property).Accept(visitor);
        }

        public static void VisitStaticClassPropertyChildren<TStaticClassProperty, TProperty, TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TVisitor>(
            TStaticClassProperty property,
            Func<TStaticClassProperty, TProperty> propertyFactory,
            TVisitor visitor)
            where TStaticClassProperty : IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IStaticClassAccessor, IVisitable<TVisitor>
        {
            propertyFactory(property).Accept(visitor);
        }

        public static void VisitStructPropertyChildren<TStructProperty, TProperty, TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TVisitor>(
            TStructProperty property,
            Func<TStructProperty, TProperty> propertyFactory,
            TVisitor visitor)
            where TStructProperty : IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IStructAccessor, IVisitable<TVisitor>
        {
            propertyFactory(property).Accept(visitor);
        }

        public static void VisitExtensionMethodChildren<TExtensionMethod, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody, TVisitor>(
            TExtensionMethod method,
            TVisitor visitor)
            where TExtensionMethod : IExtensionMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TExtensionParameter, TParameter, TMethodBody>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticClass, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TExtensionParameter : IExtensionParameter, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            
        }

        public static void VisitNestedStructCollectionChildren<TNestedStructCollection, TStruct, TPartialStruct, TVisitor>(
            TNestedStructCollection structCollection,
            TVisitor visitor)
            where TNestedStructCollection : INestedStructCollection<TStruct, TPartialStruct>
            where TStruct : INestedStruct, IVisitable<TVisitor>
            where TPartialStruct : INestedPartialStruct, IVisitable<TVisitor>
        {
            VisitCollection(structCollection, visitor);
            VisitCollection(structCollection.PartialStructs, visitor);
        }

        public static void VisitClassNestedStructCollectionChildren<TClassNestedStructCollection, TNestedStructCollection, TStruct, TPartialStruct, TVisitor>(
            TClassNestedStructCollection structCollection,
            Func<TClassNestedStructCollection, TNestedStructCollection> nestedStructCollectionFactory,
            TVisitor visitor)
            where TClassNestedStructCollection : IClassNestedStructCollection<TStruct, TPartialStruct>
            where TNestedStructCollection : INestedStructCollection<TStruct, TPartialStruct>, IVisitable<TVisitor>
            where TStruct : IClassNestedStruct, IVisitable<TVisitor>
            where TPartialStruct : IClassNestedPartialStruct, IVisitable<TVisitor>
        {
            nestedStructCollectionFactory(structCollection).Accept(visitor);
        }

        public static void VisitStaticClassNestedStructCollectionChildren<TStaticClassNestedStructCollection, TNestedStructCollection, TStruct, TPartialStruct, TVisitor>(
            TStaticClassNestedStructCollection structCollection,
            Func<TStaticClassNestedStructCollection, TNestedStructCollection> nestedStructCollectionFactory,
            TVisitor visitor)
            where TStaticClassNestedStructCollection : IStaticClassNestedStructCollection<TStruct, TPartialStruct>
            where TNestedStructCollection : INestedStructCollection<TStruct, TPartialStruct>, IVisitable<TVisitor>
            where TStruct : IStaticClassNestedStruct, IVisitable<TVisitor>
            where TPartialStruct : IStaticClassNestedPartialStruct, IVisitable<TVisitor>
        {
            nestedStructCollectionFactory(structCollection).Accept(visitor);
        }

        public static void VisitStructNestedStructCollectionChildren<TStructNestedStructCollection, TNestedStructCollection, TStruct, TPartialStruct, TVisitor>(
            TStructNestedStructCollection structCollection,
            Func<TStructNestedStructCollection, TNestedStructCollection> nestedStructCollectionFactory,
            TVisitor visitor)
            where TStructNestedStructCollection : IStructNestedStructCollection<TStruct, TPartialStruct>
            where TNestedStructCollection : INestedStructCollection<TStruct, TPartialStruct>, IVisitable<TVisitor>
            where TStruct : IStructNestedStruct, IVisitable<TVisitor>
            where TPartialStruct : IStructNestedPartialStruct, IVisitable<TVisitor>
        {
            nestedStructCollectionFactory(structCollection).Accept(visitor);
        }

        public static void VisitNestedClassCollectionChildren<TNestedClassCollection, TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection, TVisitor>(
            TNestedClassCollection classCollection,
            TVisitor visitor)
            where TNestedClassCollection : INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
            where TClass : INestedClass, IVisitable<TVisitor>
            where TAbstractClass : INestedAbstractClass, IVisitable<TVisitor>
            where TSealedClass : INestedSealedClass, IVisitable<TVisitor>
            where TStaticClass : INestedStaticClass, IVisitable<TVisitor>
            where TPartialClassCollection : IPartialClassCollection, IVisitable<TVisitor>
        {
            VisitCollection(classCollection, visitor);
            VisitCollection(classCollection.AbstractClasses, visitor);
            VisitCollection(classCollection.SealedClasses, visitor);
            VisitCollection(classCollection.StaticClasses, visitor);
            VisitIfNotNull(classCollection.PartialClasses, visitor);
        }

        public static void VisitClassNestedClassCollectionChildren<TClassNestedClassCollection, TNestedClassCollection, TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection, TVisitor>(
            TClassNestedClassCollection nestedClass,
            Func<TClassNestedClassCollection, TNestedClassCollection> nestedClassCollectionFactory,
            TVisitor visitor)
            where TClassNestedClassCollection : IClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
            where TNestedClassCollection : INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>, IVisitable<TVisitor>
            where TClass : IClassNestedClass, IVisitable<TVisitor>
            where TAbstractClass : IClassNestedAbstractClass, IVisitable<TVisitor>
            where TSealedClass : IClassNestedSealedClass, IVisitable<TVisitor>
            where TStaticClass : IClassNestedStaticClass, IVisitable<TVisitor>
            where TPartialClassCollection : IPartialClassCollection, IVisitable<TVisitor>
        {
            nestedClassCollectionFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedClassCollectionChildren<TStaticClassNestedClassCollection, TNestedClassCollection, TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection, TVisitor>(
            TStaticClassNestedClassCollection nestedClass,
            Func<TStaticClassNestedClassCollection, TNestedClassCollection> nestedClassCollectionFactory,
            TVisitor visitor)
            where TStaticClassNestedClassCollection : IStaticClassNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
            where TNestedClassCollection : INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>, IVisitable<TVisitor>
            where TClass : IStaticClassNestedClass, IVisitable<TVisitor>
            where TAbstractClass : IStaticClassNestedAbstractClass, IVisitable<TVisitor>
            where TSealedClass : IStaticClassNestedSealedClass, IVisitable<TVisitor>
            where TStaticClass : IStaticClassNestedStaticClass, IVisitable<TVisitor>
            where TPartialClassCollection : IPartialClassCollection, IVisitable<TVisitor>
        {
            nestedClassCollectionFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedClassCollectionChildren<TStructNestedClassCollection, TNestedClassCollection, TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection, TVisitor>(
            TStructNestedClassCollection nestedClass,
            Func<TStructNestedClassCollection, TNestedClassCollection> nestedClassCollectionFactory,
            TVisitor visitor)
            where TStructNestedClassCollection : IStructNestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>
            where TNestedClassCollection : INestedClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass, TPartialClassCollection>, IVisitable<TVisitor>
            where TClass : IStructNestedClass, IVisitable<TVisitor>
            where TAbstractClass : IStructNestedAbstractClass, IVisitable<TVisitor>
            where TSealedClass : IStructNestedSealedClass, IVisitable<TVisitor>
            where TStaticClass : IStructNestedStaticClass, IVisitable<TVisitor>
            where TPartialClassCollection : IPartialClassCollection, IVisitable<TVisitor>
        {
            nestedClassCollectionFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticTypeChildren<TStaticType, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStaticType type,
            TVisitor visitor)
            where TStaticType : IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : IStaticClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            VisitIfNotNull(type.Events, visitor);
            VisitIfNotNull(type.Properties, visitor);
            VisitIfNotNull(type.Methods, visitor);
            VisitIfNotNull(type.Fields, visitor);
            VisitIfNotNull(type.Classes, visitor);
            VisitCollection(type.Delegates, visitor);
            VisitCollection(type.Enums, visitor);
            VisitCollection(type.Interfaces, visitor);
            VisitIfNotNull(type.Structs, visitor);
            VisitIfNotNull(type.StaticConstructor, visitor);
        }

        public static void VisitNestedStaticClassChildren<TNestedStaticClass, TStaticType, TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TNestedStaticClass @class,
            Func<TNestedStaticClass, TStaticType> staticTypeFactory,
            TVisitor visitor)
            where TNestedStaticClass : INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStaticType : IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : INestedStaticClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            staticTypeFactory(@class).Accept(visitor);
        }

        public static void VisitClassNestedStaticClassChildren<TClassNestedStaticClass, TNestedStaticClass, TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TClassNestedStaticClass nestedClass,
            Func<TClassNestedStaticClass, TNestedStaticClass> nestedStaticClassFactory,
            TVisitor visitor)
            where TClassNestedStaticClass : IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TNestedStaticClass : INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : INestedStaticClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            nestedStaticClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitClassNestedStaticPartialClassChildren<TClassNestedStaticPartialClass, TClassNestedStaticClass, TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TClassNestedStaticPartialClass nestedClass,
            Func<TClassNestedStaticPartialClass, TClassNestedStaticClass> classNestedStaticClassFactory,
            TVisitor visitor)
            where TClassNestedStaticPartialClass : IClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TClassNestedStaticClass : IClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : INestedStaticPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            classNestedStaticClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedStaticClassChildren<TStaticClassNestedStaticClass, TNestedStaticClass, TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStaticClassNestedStaticClass nestedClass,
            Func<TStaticClassNestedStaticClass, TNestedStaticClass> nestedStaticClassFactory,
            TVisitor visitor)
            where TStaticClassNestedStaticClass : IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TNestedStaticClass : INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : INestedStaticClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            nestedStaticClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedStaticPartialClassChildren<TStaticClassNestedStaticPartialClass, TStaticClassNestedStaticClass, TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStaticClassNestedStaticPartialClass nestedClass,
            Func<TStaticClassNestedStaticPartialClass, TStaticClassNestedStaticClass> staticClassNestedStaticClassFactory,
            TVisitor visitor)
            where TStaticClassNestedStaticPartialClass : IStaticClassNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStaticClassNestedStaticClass : IStaticClassNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : INestedStaticPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            staticClassNestedStaticClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedStaticClassChildren<TStructNestedStaticClass, TNestedStaticClass, TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStructNestedStaticClass nestedClass,
            Func<TStructNestedStaticClass, TNestedStaticClass> nestedStaticClassFactory,
            TVisitor visitor)
            where TStructNestedStaticClass : IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TNestedStaticClass : INestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : INestedStaticClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            nestedStaticClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedStaticPartialClassChildren<TStructNestedStaticPartialClass, TStructNestedStaticClass, TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStructNestedStaticPartialClass nestedClass,
            Func<TStructNestedStaticPartialClass, TStructNestedStaticClass> structNestedStaticClassFactory,
            TVisitor visitor)
            where TStructNestedStaticPartialClass : IStructNestedStaticPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStructNestedStaticClass : IStructNestedStaticClass<TAttributeGroup, TDeclaringType, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : INestedStaticPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            structNestedStaticClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitClassNestedAbstractClassChildren<TClassNestedAbstractClass, TNestedAbstractClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClassNestedAbstractClass nestedClass,
            Func<TClassNestedAbstractClass, TNestedAbstractClass> nestedAbstractClassFactory,
            TVisitor visitor)
            where TClassNestedAbstractClass : IClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedAbstractClass : INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedAbstractClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitClassNestedAbstractPartialClassChildren<TClassNestedAbstractPartialClass, TClassNestedAbstractClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClassNestedAbstractPartialClass nestedClass,
            Func<TClassNestedAbstractPartialClass, TClassNestedAbstractClass> classNestedAbstractClassFactory,
            TVisitor visitor)
            where TClassNestedAbstractPartialClass : IClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TClassNestedAbstractClass : IClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            classNestedAbstractClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedAbstractClassChildren<TStaticClassNestedAbstractClass, TNestedAbstractClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStaticClassNestedAbstractClass nestedClass,
            Func<TStaticClassNestedAbstractClass, TNestedAbstractClass> nestedAbstractClassFactory,
            TVisitor visitor)
            where TStaticClassNestedAbstractClass : IStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedAbstractClass : INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedAbstractClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedAbstractPartialClassChildren<TStaticClassNestedAbstractPartialClass, TStaticClassNestedAbstractClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStaticClassNestedAbstractPartialClass nestedClass,
            Func<TStaticClassNestedAbstractPartialClass, TStaticClassNestedAbstractClass> staticClassNestedAbstractClassFactory,
            TVisitor visitor)
            where TStaticClassNestedAbstractPartialClass : IStaticClassNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TStaticClassNestedAbstractClass : IStaticClassNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            staticClassNestedAbstractClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedAbstractClassChildren<TStructNestedAbstractClass, TNestedAbstractClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStructNestedAbstractClass nestedClass,
            Func<TStructNestedAbstractClass, TNestedAbstractClass> nestedAbstractClassFactory,
            TVisitor visitor)
            where TStructNestedAbstractClass : IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedAbstractClass : INestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedAbstractClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedAbstractPartialClassChildren<TStructNestedAbstractPartialClass, TStructNestedAbstractClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStructNestedAbstractPartialClass nestedClass,
            Func<TStructNestedAbstractPartialClass, TStructNestedAbstractClass> structNestedAbstractClassFactory,
            TVisitor visitor)
            where TStructNestedAbstractPartialClass : IStructNestedAbstractPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TStructNestedAbstractClass : IStructNestedAbstractClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            structNestedAbstractClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitAbstractClassChildren<TAbstractClass, TClass, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TAbstractClass @class,
            Func<TAbstractClass, TClass> classFactory,
            TVisitor visitor)
            where TAbstractClass : IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TClass : IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            classFactory(@class).Accept(visitor);
        }

        public static void VisitAbstractPartialClassChildren<TAbstractPartialClass, TAbstractClass, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TAbstractPartialClass @class,
            Func<TAbstractPartialClass, TAbstractClass> abstractClassFactory,
            TVisitor visitor)
            where TAbstractPartialClass : IAbstractPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TAbstractClass : IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IAbstractClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IAbstractClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IAbstractClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IAbstractPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            abstractClassFactory(@class).Accept(visitor);
        }

        public static void VisitSealedClassChildren<TSealedClass, TClass, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TSealedClass @class,
            Func<TSealedClass, TClass> classFactory,
            TVisitor visitor)
            where TSealedClass : ISealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TClass : IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            classFactory(@class).Accept(visitor);
        }

        public static void VisitSealedPartialClassChildren<TSealedPartialClass, TSealedClass, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TSealedPartialClass @class,
            Func<TSealedPartialClass, TSealedClass> sealedClassFactory,
            TVisitor visitor)
            where TSealedPartialClass : ISealedPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TSealedClass : ISealedClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            sealedClassFactory(@class).Accept(visitor);
        }

        public static void VisitStaticClassChildren<TStaticClass, TStaticType, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStaticClass @class,
            Func<TStaticClass, TStaticType> staticTypeFactory,
            TVisitor visitor)
            where TStaticClass : IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStaticType : IStaticType<TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : IStaticClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            staticTypeFactory(@class).Accept(visitor);
        }

        public static void VisitStaticPartialClassChildren<TStaticPartialClass, TStaticClass, TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStaticPartialClass @class,
            Func<TStaticPartialClass, TStaticClass> staticClassFactory,
            TVisitor visitor)
            where TStaticPartialClass : IStaticPartialClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStaticClass : IStaticClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TEventCollection, TPropertyCollection, TMethodCollection, TFieldCollection, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TNamespace : INamespace, IVisitable<TVisitor>
            where TDocument : IDocument
            where TProject : IProject
            where TSolution : ISolution
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TEventCollection : IStaticClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStaticClassPropertyCollection, IVisitable<TVisitor>
            where TMethodCollection : IStaticPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStaticClassFieldCollection, IVisitable<TVisitor>
            where TNestedClassCollection : IStaticClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStaticClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStaticClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStaticClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStaticClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            staticClassFactory(@class).Accept(visitor);
        }

        public static void VisitClassNestedSealedClassChildren<TClassNestedSealedClass, TNestedSealedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClassNestedSealedClass nestedClass,
            Func<TClassNestedSealedClass, TNestedSealedClass> nestedSealedClassFactory,
            TVisitor visitor)
            where TClassNestedSealedClass : IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedSealedClass : INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedSealedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitClassNestedSealedPartialClassChildren<TClassNestedSealedPartialClass, TClassNestedSealedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClassNestedSealedPartialClass nestedClass,
            Func<TClassNestedSealedPartialClass, TClassNestedSealedClass> classNestedSealedClassFactory,
            TVisitor visitor)
            where TClassNestedSealedPartialClass : IClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TClassNestedSealedClass : IClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            classNestedSealedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedSealedClassChildren<TStaticClassNestedSealedClass, TNestedSealedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStaticClassNestedSealedClass nestedClass,
            Func<TStaticClassNestedSealedClass, TNestedSealedClass> nestedSealedClassFactory,
            TVisitor visitor)
            where TStaticClassNestedSealedClass : IStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedSealedClass : INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedSealedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedSealedPartialClassChildren<TStaticClassNestedSealedPartialClass, TStaticClassNestedSealedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStaticClassNestedSealedPartialClass nestedClass,
            Func<TStaticClassNestedSealedPartialClass, TStaticClassNestedSealedClass> staticClassNestedSealedClassFactory,
            TVisitor visitor)
            where TStaticClassNestedSealedPartialClass : IStaticClassNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TStaticClassNestedSealedClass : IStaticClassNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            staticClassNestedSealedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedSealedClassChildren<TStructNestedSealedClass, TNestedSealedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStructNestedSealedClass nestedClass,
            Func<TStructNestedSealedClass, TNestedSealedClass> nestedSealedClassFactory,
            TVisitor visitor)
            where TStructNestedSealedClass : IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedSealedClass : INestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedSealedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedSealedPartialClassChildren<TStructNestedSealedPartialClass, TStructNestedSealedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStructNestedSealedPartialClass nestedClass,
            Func<TStructNestedSealedPartialClass, TStructNestedSealedClass> structNestedSealedClassFactory,
            TVisitor visitor)
            where TStructNestedSealedPartialClass : IStructNestedSealedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TStructNestedSealedClass : IStructNestedSealedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : ISealedClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : ISealedClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : ISealedClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : ISealedPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            structNestedSealedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassEventCollectionChildren<TStaticClassEventCollection, TEvent, TEventProperty, TVisitor>(
            TStaticClassEventCollection eventCollection,
            TVisitor visitor)
            where TStaticClassEventCollection : IStaticClassEventCollection<TEvent, TEventProperty>
            where TEvent : IStaticClassEvent, IVisitable<TVisitor>
            where TEventProperty : IStaticClassEventProperty, IVisitable<TVisitor>
        {
            VisitCollection(eventCollection, visitor);
            VisitCollection(eventCollection.EventProperties, visitor);
        }

        public static void VisitStaticClassMethodCollectionChildren<TStaticClassMethodCollection, TMethod, TExtensionMethod, TVisitor>(
            TStaticClassMethodCollection methodCollection,
            TVisitor visitor)
            where TStaticClassMethodCollection : IStaticClassMethodCollection<TMethod, TExtensionMethod>
            where TMethod : IStaticClassMethod, IVisitable<TVisitor>
            where TExtensionMethod : IExtensionMethod, IVisitable<TVisitor>
        {
            VisitCollection(methodCollection, visitor);
            VisitCollection(methodCollection.ExtensionMethods, visitor);
        }

        public static void VisitStaticPartialClassMethodCollectionChildren<TStaticPartialClassMethodCollection, TStaticClassMethodCollection, TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation, TVisitor>(
            TStaticPartialClassMethodCollection methodCollection,
            Func<TStaticPartialClassMethodCollection, TStaticClassMethodCollection> staticClassMethodCollectionFactory,
            TVisitor visitor)
            where TStaticPartialClassMethodCollection : IStaticPartialClassMethodCollection<TMethod, TExtensionMethod, TPartialMethodDefinition, TPartialMethodImplementation>
            where TStaticClassMethodCollection : IStaticClassMethodCollection<TMethod, TExtensionMethod>, IVisitable<TVisitor>
            where TMethod : IStaticClassMethod, IVisitable<TVisitor>
            where TExtensionMethod : IExtensionMethod, IVisitable<TVisitor>
            where TPartialMethodDefinition : IPartialMethodDefinition, IVisitable<TVisitor>
            where TPartialMethodImplementation : IPartialMethodImplementation, IVisitable<TVisitor>
        {
            staticClassMethodCollectionFactory(methodCollection).Accept(visitor);
            VisitCollection(methodCollection.PartialMethodDefinitions, visitor);
            VisitCollection(methodCollection.PartialMethodImplementations, visitor);
        }

        public static void VisitNestedStaticClassMethodCollectionChildren<TNestedStaticClassMethodCollection, TMethod, TVisitor>(
            TNestedStaticClassMethodCollection methodCollection,
            TVisitor visitor)
            where TNestedStaticClassMethodCollection : INestedStaticClassMethodCollection<TMethod>
            where TMethod : IStaticClassMethod, IVisitable<TVisitor>
        {
            VisitCollection(methodCollection, visitor);
        }

        public static void VisitNestedStaticPartialClassMethodCollectionChildren<TNestedStaticPartialClassMethodCollection, TNestedStaticClassMethodCollection, TMethod, TPartialMethodDefinition, TPartialMethodImplementation, TVisitor>(
            TNestedStaticPartialClassMethodCollection methodCollection,
            Func<TNestedStaticPartialClassMethodCollection, TNestedStaticClassMethodCollection> nestedStaticClassMethodCollectionFactory,
            TVisitor visitor)
            where TNestedStaticPartialClassMethodCollection : INestedStaticPartialClassMethodCollection<TMethod, TPartialMethodDefinition, TPartialMethodImplementation>
            where TNestedStaticClassMethodCollection : INestedStaticClassMethodCollection<TMethod>, IVisitable<TVisitor>
            where TMethod : IStaticClassMethod, IVisitable<TVisitor>
            where TPartialMethodDefinition : IPartialMethodDefinition, IVisitable<TVisitor>
            where TPartialMethodImplementation : IPartialMethodImplementation, IVisitable<TVisitor>
        {
            nestedStaticClassMethodCollectionFactory(methodCollection).Accept(visitor);
            VisitCollection(methodCollection.PartialMethodDefinitions, visitor);
            VisitCollection(methodCollection.PartialMethodImplementations, visitor);
        }

        public static void VisitExplicitInterfacePropertyChildren<TExplicitInterfaceProperty, TProperty, TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor, TVisitor>(
            TExplicitInterfaceProperty property,
            Func<TExplicitInterfaceProperty, TProperty> propertyFactory,
            TVisitor visitor)
            where TExplicitInterfaceProperty : IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>
            where TProperty : IProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TAccessor : IAccessor, IVisitable<TVisitor>
        {
            VisitIfNotNull(property.ExplicitInterface, visitor);
            propertyFactory(property).Accept(visitor);
        }

        public static void VisitExplicitInterfaceEventChildren<TExplicitInterfaceEvent, TEventProperty, TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody, TVisitor>(
            TExplicitInterfaceEvent @event,
            Func<TExplicitInterfaceEvent, TEventProperty> eventPropertyFactory,
            TVisitor visitor)
            where TExplicitInterfaceEvent : IExplicitInterfaceEvent<TAttributeGroup, TDeclaringType, TInterfaceReference, TDelegateReference, TMethodBody>
            where TEventProperty : IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitIfNotNull(@event.ExplicitInterface, visitor);
            eventPropertyFactory(@event).Accept(visitor);
        }

        public static void VisitClassEventPropertyChildren<TClassEventProperty, TEventProperty, TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody, TVisitor>(
            TClassEventProperty @event,
            Func<TClassEventProperty, TEventProperty> eventPropertyFactory,
            TVisitor visitor)
            where TClassEventProperty : IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
            where TEventProperty : IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            eventPropertyFactory(@event).Accept(visitor);
        }

        public static void VisitSealedClassEventPropertyChildren<TSealedClassEventProperty, TEventProperty, TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody, TVisitor>(
            TSealedClassEventProperty @event,
            Func<TSealedClassEventProperty, TEventProperty> eventPropertyFactory,
            TVisitor visitor)
            where TSealedClassEventProperty : ISealedClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
            where TEventProperty : IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : ISealedType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            eventPropertyFactory(@event).Accept(visitor);
        }

        public static void VisitStaticClassEventPropertyChildren<TStaticClassEventProperty, TEventProperty, TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody, TVisitor>(
            TStaticClassEventProperty @event,
            Func<TStaticClassEventProperty, TEventProperty> eventPropertyFactory,
            TVisitor visitor)
            where TStaticClassEventProperty : IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
            where TEventProperty : IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            eventPropertyFactory(@event).Accept(visitor);
        }

        public static void VisitStructEventPropertyChildren<TStructEventProperty, TEventProperty, TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody, TVisitor>(
            TStructEventProperty @event,
            Func<TStructEventProperty, TEventProperty> eventPropertyFactory,
            TVisitor visitor)
            where TStructEventProperty : IStructEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
            where TEventProperty : IEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TDelegateReference : IDelegateReference, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            eventPropertyFactory(@event).Accept(visitor);
        }

        public static void VisitExplicitInterfaceIndexerChildren<TExplicitInterfaceIndexer, TIndexer, TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor, TVisitor>(
            TExplicitInterfaceIndexer indexer,
            Func<TExplicitInterfaceIndexer, TIndexer> indexerFactory,
            TVisitor visitor)
            where TExplicitInterfaceIndexer : IExplicitInterfaceIndexer<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TParameter, TAccessor>
            where TIndexer : IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IIndexerParameter, IVisitable<TVisitor>
            where TAccessor : IAccessor, IVisitable<TVisitor>
        {
            VisitIfNotNull(indexer.ExplicitInterface, visitor);
            indexerFactory(indexer).Accept(visitor);
        }

        public static void VisitClassIndexerChildren<TClassIndexer, TIndexer, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor, TVisitor>(
            TClassIndexer indexer,
            Func<TClassIndexer, TIndexer> indexerFactory,
            TVisitor visitor)
            where TClassIndexer : IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
            where TIndexer : IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IIndexerParameter, IVisitable<TVisitor>
            where TAccessor : IClassAccessor, IVisitable<TVisitor>
        {
            indexerFactory(indexer).Accept(visitor);
        }

        public static void VisitInterfaceIndexerChildren<TInterfaceIndexer, TIndexer, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor, TVisitor>(
            TInterfaceIndexer indexer,
            Func<TInterfaceIndexer, TIndexer> indexerFactory,
            TVisitor visitor)
            where TInterfaceIndexer : IInterfaceIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
            where TIndexer : IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IInterfaceType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IIndexerParameter, IVisitable<TVisitor>
            where TAccessor : IInterfaceAccessor, IVisitable<TVisitor>
        {
            indexerFactory(indexer).Accept(visitor);
        }

        public static void VisitSealedClassIndexerChildren<TSealedClassIndexer, TIndexer, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor, TVisitor>(
            TSealedClassIndexer indexer,
            Func<TSealedClassIndexer, TIndexer> indexerFactory,
            TVisitor visitor)
            where TSealedClassIndexer : ISealedClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
            where TIndexer : IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : ISealedType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IIndexerParameter, IVisitable<TVisitor>
            where TAccessor : IClassAccessor, IVisitable<TVisitor>
        {
            indexerFactory(indexer).Accept(visitor);
        }

        public static void VisitStructIndexerChildren<TStructIndexer, TIndexer, TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor, TVisitor>(
            TStructIndexer indexer,
            Func<TStructIndexer, TIndexer> indexerFactory,
            TVisitor visitor)
            where TStructIndexer : IStructIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>
            where TIndexer : IIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IIndexerParameter, IVisitable<TVisitor>
            where TAccessor : IStructAccessor, IVisitable<TVisitor>
        {
            indexerFactory(indexer).Accept(visitor);
        }

        public static void VisitExplicitInterfaceMethodChildren<TExplicitInterfaceMethod, TMethod, TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody, TVisitor>(
            TExplicitInterfaceMethod method,
            Func<TExplicitInterfaceMethod, TMethod> methodFactory,
            TVisitor visitor)
            where TExplicitInterfaceMethod : IExplicitInterfaceMethod<TAttributeGroup, TDeclaringType, TInterfaceReference, TGenericParameter, TTypeReference, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TMethod : IMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IType, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IMethodParameter, IVisitable<TVisitor>
            where TMethodBody : IMethodBody, IVisitable<TVisitor>
        {
            VisitIfNotNull(method, visitor);
            methodFactory(method).Accept(visitor);
        }

        public static void VisitClassNestedClassChildren<TClassNestedClass, TNestedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClassNestedClass nestedClass,
            Func<TClassNestedClass, TNestedClass> nestedClassFactory,
            TVisitor visitor)
            where TClassNestedClass : IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedClass : INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitClassNestedPartialClassChildren<TClassNestedPartialClass, TClassNestedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TClassNestedPartialClass nestedClass,
            Func<TClassNestedPartialClass, TClassNestedClass> classNestedClassFactory,
            TVisitor visitor)
            where TClassNestedPartialClass : IClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TClassNestedClass : IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            classNestedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedClassChildren<TStaticClassNestedClass, TNestedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStaticClassNestedClass nestedClass,
            Func<TStaticClassNestedClass, TNestedClass> nestedClassFactory,
            TVisitor visitor)
            where TStaticClassNestedClass : IStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedClass : INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStaticClassNestedPartialClassChildren<TStaticClassNestedPartialClass, TStaticClassNestedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStaticClassNestedPartialClass nestedClass,
            Func<TStaticClassNestedPartialClass, TStaticClassNestedClass> staticClassNestedClassFactory,
            TVisitor visitor)
            where TStaticClassNestedPartialClass : IStaticClassNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TStaticClassNestedClass : IStaticClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            staticClassNestedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedClassChildren<TStructNestedClass, TNestedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStructNestedClass nestedClass,
            Func<TStructNestedClass, TNestedClass> nestedClassFactory,
            TVisitor visitor)
            where TStructNestedClass : IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TNestedClass : INestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            nestedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitStructNestedPartialClassChildren<TStructNestedPartialClass, TStructNestedClass, TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor, TVisitor>(
            TStructNestedPartialClass nestedClass,
            Func<TStructNestedPartialClass, TStructNestedClass> structNestedClassFactory,
            TVisitor visitor)
            where TStructNestedPartialClass : IStructNestedPartialClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>
            where TStructNestedClass : IStructNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TClassReference : IClassReference, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IClassEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IClassPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IClassIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialClassMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IClassFieldCollection, IVisitable<TVisitor>
            where TConstructor : IClassConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IClassNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IClassNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IClassNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IClassNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IClassNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
            where TDestructor : IDestructor, IVisitable<TVisitor>
        {
            structNestedClassFactory(nestedClass).Accept(visitor);
        }

        public static void VisitClassNestedDelegateChildren<TClassNestedDelegate, TNestedDelegate, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TClassNestedDelegate nestedDelegate,
            Func<TClassNestedDelegate, TNestedDelegate> nestedDelegateFactory,
            TVisitor visitor)
            where TClassNestedDelegate : IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
            where TNestedDelegate : INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IDelegateParameter, IVisitable<TVisitor>
        {
            nestedDelegateFactory(nestedDelegate).Accept(visitor);
        }

        public static void VisitStaticClassNestedDelegateChildren<TStaticClassNestedDelegate, TNestedDelegate, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TStaticClassNestedDelegate nestedDelegate,
            Func<TStaticClassNestedDelegate, TNestedDelegate> nestedDelegateFactory,
            TVisitor visitor)
            where TStaticClassNestedDelegate : IStaticClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
            where TNestedDelegate : INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IDelegateParameter, IVisitable<TVisitor>
        {
            nestedDelegateFactory(nestedDelegate).Accept(visitor);
        }

        public static void VisitStructNestedDelegateChildren<TStructNestedDelegate, TNestedDelegate, TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TVisitor>(
            TStructNestedDelegate nestedDelegate,
            Func<TStructNestedDelegate, TNestedDelegate> nestedDelegateFactory,
            TVisitor visitor)
            where TStructNestedDelegate : IStructNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>
            where TNestedDelegate : INestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TTypeReference : ITypeReference, IVisitable<TVisitor>
            where TParameter : IDelegateParameter, IVisitable<TVisitor>
        {
            nestedDelegateFactory(nestedDelegate).Accept(visitor);
        }

        public static void VisitClassNestedEnumChildren<TClassNestedEnum, TNestedEnum, TAttributeGroup, TDeclaringType, TNestedEnumMember, TVisitor>(
            TClassNestedEnum nestedEnum,
            Func<TClassNestedEnum, TNestedEnum> nestedEnumFactory,
            TVisitor visitor)
            where TClassNestedEnum : IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
            where TNestedEnum : INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TNestedEnumMember : INestedEnumMember, IVisitable<TVisitor>
        {
            nestedEnumFactory(nestedEnum).Accept(visitor);
        }

        public static void VisitStaticClassNestedEnumChildren<TStaticClassNestedEnum, TNestedEnum, TAttributeGroup, TDeclaringType, TNestedEnumMember, TVisitor>(
            TStaticClassNestedEnum nestedEnum,
            Func<TStaticClassNestedEnum, TNestedEnum> nestedEnumFactory,
            TVisitor visitor)
            where TStaticClassNestedEnum : IStaticClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
            where TNestedEnum : INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TNestedEnumMember : INestedEnumMember, IVisitable<TVisitor>
        {
            nestedEnumFactory(nestedEnum).Accept(visitor);
        }

        public static void VisitStructNestedEnumChildren<TStructNestedEnum, TNestedEnum, TAttributeGroup, TDeclaringType, TNestedEnumMember, TVisitor>(
            TStructNestedEnum nestedEnum,
            Func<TStructNestedEnum, TNestedEnum> nestedEnumFactory,
            TVisitor visitor)
            where TStructNestedEnum : IStructNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>
            where TNestedEnum : INestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TNestedEnumMember : INestedEnumMember, IVisitable<TVisitor>
        {
            nestedEnumFactory(nestedEnum).Accept(visitor);
        }

        public static void VisitClassNestedInterfaceChildren<TClassNestedInterface, TNestedInterface, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TVisitor>(
            TClassNestedInterface @interface,
            Func<TClassNestedInterface, TNestedInterface> nestedInterfaceFactory,
            TVisitor visitor)
            where TClassNestedInterface : IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
            where TNestedInterface : INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEvent : IInterfaceEvent, IVisitable<TVisitor>
            where TProperty : IInterfaceProperty, IVisitable<TVisitor>
            where TIndexer : IInterfaceIndexer, IVisitable<TVisitor>
            where TMethod : IInterfaceMethod, IVisitable<TVisitor>
        {
            nestedInterfaceFactory(@interface).Accept(visitor);
        }

        public static void VisitStaticClassNestedInterfaceChildren<TStaticClassNestedInterface, TNestedInterface, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TVisitor>(
            TStaticClassNestedInterface @interface,
            Func<TStaticClassNestedInterface, TNestedInterface> nestedInterfaceFactory,
            TVisitor visitor)
            where TStaticClassNestedInterface : IStaticClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
            where TNestedInterface : INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEvent : IInterfaceEvent, IVisitable<TVisitor>
            where TProperty : IInterfaceProperty, IVisitable<TVisitor>
            where TIndexer : IInterfaceIndexer, IVisitable<TVisitor>
            where TMethod : IInterfaceMethod, IVisitable<TVisitor>
        {
            nestedInterfaceFactory(@interface).Accept(visitor);
        }

        public static void VisitStructNestedInterfaceChildren<TStructNestedInterface, TNestedInterface, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TVisitor>(
            TStructNestedInterface @interface,
            Func<TStructNestedInterface, TNestedInterface> nestedInterfaceFactory,
            TVisitor visitor)
            where TStructNestedInterface : IStructNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>
            where TNestedInterface : INestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEvent : IInterfaceEvent, IVisitable<TVisitor>
            where TProperty : IInterfaceProperty, IVisitable<TVisitor>
            where TIndexer : IInterfaceIndexer, IVisitable<TVisitor>
            where TMethod : IInterfaceMethod, IVisitable<TVisitor>
        {
            nestedInterfaceFactory(@interface).Accept(visitor);
        }

        public static void VisitClassNestedStructChildren<TClassNestedStruct, TNestedStruct, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TClassNestedStruct nestedStruct,
            Func<TClassNestedStruct, TNestedStruct> nestedStructFactory,
            TVisitor visitor)
            where TClassNestedStruct : IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TNestedStruct : INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            nestedStructFactory(nestedStruct).Accept(visitor);
        }

        public static void VisitClassNestedPartialStructChildren<TClassNestedPartialStruct, TClassNestedStruct, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TClassNestedPartialStruct nestedStruct,
            Func<TClassNestedPartialStruct, TClassNestedStruct> classNestedStructFactory,
            TVisitor visitor)
            where TClassNestedPartialStruct : IClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TClassNestedStruct : IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IClassType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            classNestedStructFactory(nestedStruct).Accept(visitor);
        }

        public static void VisitStaticClassNestedStructChildren<TStaticClassNestedStruct, TNestedStruct, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStaticClassNestedStruct nestedStruct,
            Func<TStaticClassNestedStruct, TNestedStruct> nestedStructFactory,
            TVisitor visitor)
            where TStaticClassNestedStruct : IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TNestedStruct : INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            nestedStructFactory(nestedStruct).Accept(visitor);
        }

        public static void VisitStaticClassNestedPartialStructChildren<TStaticClassNestedPartialStruct, TStaticClassNestedStruct, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStaticClassNestedPartialStruct nestedStruct,
            Func<TStaticClassNestedPartialStruct, TStaticClassNestedStruct> staticClassNestedStructFactory,
            TVisitor visitor)
            where TStaticClassNestedPartialStruct : IStaticClassNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStaticClassNestedStruct : IStaticClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStaticType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            staticClassNestedStructFactory(nestedStruct).Accept(visitor);
        }

        public static void VisitStructNestedStructChildren<TStructNestedStruct, TNestedStruct, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStructNestedStruct nestedStruct,
            Func<TStructNestedStruct, TNestedStruct> nestedStructFactory,
            TVisitor visitor)
            where TStructNestedStruct : IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TNestedStruct : INestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            nestedStructFactory(nestedStruct).Accept(visitor);
        }

        public static void VisitStructNestedPartialStructChildren<TStructNestedPartialStruct, TStructNestedStruct, TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TVisitor>(
            TStructNestedPartialStruct nestedStruct,
            Func<TStructNestedPartialStruct, TStructNestedStruct> structNestedStructFactory,
            TVisitor visitor)
            where TStructNestedPartialStruct : IStructNestedPartialStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>
            where TStructNestedStruct : IStructNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>, IVisitable<TVisitor>
            where TAttributeGroup : IAttributeGroup, IVisitable<TVisitor>
            where TDeclaringType : IStructType, IVisitable<TVisitor>
            where TGenericParameter : IGenericParameterDeclaration, IVisitable<TVisitor>
            where TInterfaceReference : IInterfaceReference, IVisitable<TVisitor>
            where TEventCollection : IStructEventCollection, IVisitable<TVisitor>
            where TPropertyCollection : IStructPropertyCollection, IVisitable<TVisitor>
            where TIndexerCollection : IStructIndexerCollection, IVisitable<TVisitor>
            where TMethodCollection : IPartialStructMethodCollection, IVisitable<TVisitor>
            where TFieldCollection : IStructFieldCollection, IVisitable<TVisitor>
            where TConstructor : IStructConstructor, IVisitable<TVisitor>
            where TOperatorOverload : IOperatorOverload, IVisitable<TVisitor>
            where TConversionOperator : IConversionOperator, IVisitable<TVisitor>
            where TNestedClassCollection : IStructNestedClassCollection, IVisitable<TVisitor>
            where TNestedDelegate : IStructNestedDelegate, IVisitable<TVisitor>
            where TNestedEnum : IStructNestedEnum, IVisitable<TVisitor>
            where TNestedInterface : IStructNestedInterface, IVisitable<TVisitor>
            where TNestedStructCollection : IStructNestedStructCollection, IVisitable<TVisitor>
            where TStaticConstructor : IStaticConstructor, IVisitable<TVisitor>
        {
            structNestedStructFactory(nestedStruct).Accept(visitor);
        }

        public static void VisitPartialClassCollectionChildren<TPartialClassCollection, TClass, TAbstractClass, TSealedClass, TStaticClass, TVisitor>(
            TPartialClassCollection classes,
            TVisitor visitor)
            where TPartialClassCollection : IPartialClassCollection<TClass, TAbstractClass, TSealedClass, TStaticClass>
            where TClass : IClassType, IVisitable<TVisitor>
            where TAbstractClass : IAbstractType, IVisitable<TVisitor>
            where TSealedClass : ISealedType, IVisitable<TVisitor>
            where TStaticClass : IStaticType, IVisitable<TVisitor>
        {
            VisitCollection(classes.Classes, visitor);
            VisitCollection(classes.AbstractClasses, visitor);
            VisitCollection(classes.SealedClasses, visitor);
            VisitCollection(classes.StaticClasses, visitor);
        }
    }
}