using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;

namespace CSharpDom.Mono.Cecil.Internal
{
    /*internal class ForwardingGenericVisitor : AbstractGenericVisitor
    {
        private readonly IReflectionVisitor visitor;

        public ForwardingGenericVisitor(IReflectionVisitor visitor)
        {
            this.visitor = visitor;
        }

        public override void VisitClassAccessor<TAttributeGroup, TMethodBody>(IClassAccessor<TAttributeGroup, TMethodBody> accessor)
        {
            visitor.VisitAccessorWithMonoCecil((AccessorWithMonoCecil)(object)accessor);
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            visitor.VisitArrayTypeReferenceWithMonoCecil((ArrayTypeReferenceWithMonoCecil)(object)arrayTypeReference);
        }

        public override void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
        {
            visitor.VisitAttributeWithMonoCecil((AttributeWithMonoCecil)attribute);
        }

        public override void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>(
            IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor> @class)
        {
            visitor.VisitClassWithMonoCecil((ClassWithMonoCecil)(object)@class);
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            visitor.VisitClassReferenceWithMonoCecil((ClassReferenceWithMonoCecil)(object)classReference);
        }

        public override void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter> constructor)
        {
            visitor.VisitConstructorWithMonoCecil((ConstructorWithMonoCecil)(object)constructor);
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            visitor.VisitConversionOperatorWithMonoCecil((ConversionOperatorWithMonoCecil)(object)conversionOperator);
        }

        public override void VisitDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
            visitor.VisitDelegateWithMonoCecil((DelegateWithMonoCecil)(object)@delegate);
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            visitor.VisitDelegateReferenceWithMonoCecil((DelegateReferenceWithMonoCecil)(object)delegateReference);
        }

        public override void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
        {
            visitor.VisitDestructorWithMonoCecil((DestructorWithMonoCecil)(object)destructor);
        }

        public override void VisitEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            visitor.VisitEnumWithMonoCecil((EnumWithMonoCecil)(object)@enum);
        }

        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
            visitor.VisitEnumMemberWithMonoCecil((EnumMemberWithMonoCecil)(object)enumMember);
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            visitor.VisitEnumReferenceWithMonoCecil((EnumReferenceWithMonoCecil)enumReference);
        }

        public override void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            visitor.VisitEventWithMonoCecil((EventWithMonoCecil)(object)@event);
        }

        public override void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            visitor.VisitEventPropertyWithMonoCecil((EventPropertyWithMonoCecil)(object)eventProperty);
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            visitor.VisitFieldWithMonoCecil((FieldWithMonoCecil)(object)field);
        }

        public override void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
        {
            visitor.VisitGenericParameterWithMonoCecil((GenericParameterWithMonoCecil)(object)genericParameter);
        }

        public override void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
        {
            visitor.VisitGenericParameterDeclarationWithMonoCecil((GenericParameterDeclarationWithMonoCecil)(object)genericParameterDeclaration);
        }

        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            visitor.VisitGenericParameterReferenceWithMonoCecil((GenericParameterReferenceWithMonoCecil)genericParameterReference);
        }

        public override void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            visitor.VisitIndexerWithMonoCecil((IndexerWithMonoCecil)(object)indexer);
        }

        public override void VisitInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            visitor.VisitInterfaceWithMonoCecil((InterfaceWithMonoCecil)(object)@interface);
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            visitor.VisitInterfaceReferenceWithMonoCecil((InterfaceReferenceWithMonoCecil)(object)interfaceReference);
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
        {
            visitor.VisitAssemblyWithMonoCecil((AssemblyWithMonoCecil)(object)loadedDocument);
        }

        public override void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            visitor.VisitMethodWithMonoCecil((MethodWithMonoCecil)(object)method);
        }

        public override void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue)
        {
            visitor.VisitNamedAttributeValueWithMonoCecil((NamedAttributeValueWithMonoCecil)(object)namedAttributeValue);
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            visitor.VisitNamespaceWithMonoCecil((NamespaceWithMonoCecil)(object)@namespace);
        }

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor> nestedClass)
        {
            visitor.VisitNestedClassWithMonoCecil((NestedClassWithMonoCecil)(object)nestedClass);
        }

        public override void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            visitor.VisitNestedDelegateWithMonoCecil((NestedDelegateWithMonoCecil)(object)nestedDelegate);
        }

        public override void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
        {
            visitor.VisitDestructorWithMonoCecil((DestructorWithMonoCecil)(object)nestedDestructor);
        }

        public override void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            visitor.VisitNestedEnumWithMonoCecil((NestedEnumWithMonoCecil)(object)nestedEnum);
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
            visitor.VisitNestedEnumMemberWithMonoCecil((NestedEnumMemberWithMonoCecil)(object)nestedEnumMember);
        }

        public override void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            visitor.VisitNestedInterfaceWithMonoCecil((NestedInterfaceWithMonoCecil)(object)@interface);
        }

        public override void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> nestedStruct)
        {
            visitor.VisitNestedStructWithMonoCecil((NestedStructWithMonoCecil)(object)nestedStruct);
        }

        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            visitor.VisitNestedTypeReferenceWithMonoCecil((NestedTypeReferenceWithMonoCecil)(object)nestedTypeReference);
        }

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
            visitor.VisitOperatorOverloadWithMonoCecil((OperatorOverloadWithMonoCecil)(object)operatorOverload);
        }

        public override void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            visitor.VisitParameterWithMonoCecil((ParameterWithMonoCecil)(object)parameter);
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            visitor.VisitPropertyWithMonoCecil((PropertyWithMonoCecil)(object)property);
        }

        public override void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> @struct)
        {
            visitor.VisitStructWithMonoCecil((StructWithMonoCecil)(object)@struct);
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            visitor.VisitStructReferenceWithMonoCecil((StructReferenceWithMonoCecil)(object)structReference);
        }

        public override void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue)
        {
            visitor.VisitUnnamedAttributeValueWithMonoCecil((UnnamedAttributeValueWithMonoCecil)unnamedAttributeValue);
        }

        public override void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecifiedTypeReference<TGenericParameter> unspecifiedTypeReference)
        {
            visitor.VisitUnspecifiedTypeReferenceWithMonoCecil((UnspecifiedTypeReferenceWithMonoCecil)(object)unspecifiedTypeReference);
        }
    }*/
}
