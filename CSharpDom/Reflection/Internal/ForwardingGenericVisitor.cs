using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;

namespace CSharpDom.Reflection.Internal
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
            visitor.VisitAccessorWithReflection((AccessorWithReflection)(object)accessor);
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            visitor.VisitArrayTypeReferenceWithReflection((ArrayTypeReferenceWithReflection)(object)arrayTypeReference);
        }

        public override void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
        {
            visitor.VisitAttributeWithReflection((AttributeWithReflection)attribute);
        }

        public override void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>(
            IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor> @class)
        {
            visitor.VisitClassWithReflection((ClassWithReflection)(object)@class);
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            visitor.VisitClassReferenceWithReflection((ClassReferenceWithReflection)(object)classReference);
        }

        public override void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter> constructor)
        {
            visitor.VisitConstructorWithReflection((ConstructorWithReflection)(object)constructor);
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            visitor.VisitConversionOperatorWithReflection((ConversionOperatorWithReflection)(object)conversionOperator);
        }

        public override void VisitDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
            visitor.VisitDelegateWithReflection((DelegateWithReflection)(object)@delegate);
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            visitor.VisitDelegateReferenceWithReflection((DelegateReferenceWithReflection)(object)delegateReference);
        }

        public override void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
        {
            visitor.VisitDestructorWithReflection((DestructorWithReflection)(object)destructor);
        }

        public override void VisitEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            visitor.VisitEnumWithReflection((EnumWithReflection)(object)@enum);
        }

        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
            visitor.VisitEnumMemberWithReflection((EnumMemberWithReflection)(object)enumMember);
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            visitor.VisitEnumReferenceWithReflection((EnumReferenceWithReflection)enumReference);
        }

        public override void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            visitor.VisitEventWithReflection((EventWithReflection)(object)@event);
        }

        public override void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            visitor.VisitEventPropertyWithReflection((EventPropertyWithReflection)(object)eventProperty);
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            visitor.VisitFieldWithReflection((FieldWithReflection)(object)field);
        }

        public override void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
        {
            visitor.VisitGenericParameterWithReflection((GenericParameterWithReflection)(object)genericParameter);
        }

        public override void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
        {
            visitor.VisitGenericParameterDeclarationWithReflection((GenericParameterDeclarationWithReflection)(object)genericParameterDeclaration);
        }

        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            visitor.VisitGenericParameterReferenceWithReflection((GenericParameterReferenceWithReflection)genericParameterReference);
        }

        public override void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            visitor.VisitIndexerWithReflection((IndexerWithReflection)(object)indexer);
        }

        public override void VisitInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            visitor.VisitInterfaceWithReflection((InterfaceWithReflection)(object)@interface);
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            visitor.VisitInterfaceReferenceWithReflection((InterfaceReferenceWithReflection)(object)interfaceReference);
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
        {
            visitor.VisitAssemblyWithReflection((AssemblyWithReflection)(object)loadedDocument);
        }

        public override void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            visitor.VisitMethodWithReflection((MethodWithReflection)(object)method);
        }

        public override void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue)
        {
            visitor.VisitNamedAttributeValueWithReflection((NamedAttributeValueWithReflection)(object)namedAttributeValue);
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            visitor.VisitNamespaceWithReflection((NamespaceWithReflection)(object)@namespace);
        }

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor> nestedClass)
        {
            visitor.VisitNestedClassWithReflection((NestedClassWithReflection)(object)nestedClass);
        }

        public override void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            visitor.VisitNestedDelegateWithReflection((NestedDelegateWithReflection)(object)nestedDelegate);
        }

        public override void VisiTDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
        {
            visitor.VisiTDestructorWithReflection((NestedDestructorWithReflection)(object)nestedDestructor);
        }

        public override void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            visitor.VisitNestedEnumWithReflection((NestedEnumWithReflection)(object)nestedEnum);
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
            visitor.VisitNestedEnumMemberWithReflection((NestedEnumMemberWithReflection)(object)nestedEnumMember);
        }

        public override void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            visitor.VisitNestedInterfaceWithReflection((NestedInterfaceWithReflection)(object)@interface);
        }

        public override void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> nestedStruct)
        {
            visitor.VisitNestedStructWithReflection((NestedStructWithReflection)(object)nestedStruct);
        }

        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            visitor.VisitNestedTypeReferenceWithReflection((NestedTypeReferenceWithReflection)(object)nestedTypeReference);
        }

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
            visitor.VisitOperatorOverloadWithReflection((OperatorOverloadWithReflection)(object)operatorOverload);
        }

        public override void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            visitor.VisitParameterWithReflection((ParameterWithReflection)(object)parameter);
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            visitor.VisitPropertyWithReflection((PropertyWithReflection)(object)property);
        }

        public override void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> @struct)
        {
            visitor.VisitStructWithReflection((StructWithReflection)(object)@struct);
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            visitor.VisitStructReferenceWithReflection((StructReferenceWithReflection)(object)structReference);
        }

        public override void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue)
        {
            visitor.VisitUnnamedAttributeValueWithReflection((UnnamedAttributeValueWithReflection)unnamedAttributeValue);
        }

        public override void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecifiedTypeReference<TGenericParameter> unspecifiedTypeReference)
        {
            visitor.VisitUnspecifiedTypeReferenceWithReflection((UnspecifiedTypeReferenceWithReflection)(object)unspecifiedTypeReference);
        }
    }*/
}
