using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;

namespace CSharpDom.CodeAnalysis.Internal
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
            visitor.VisitAccessorWithCodeAnalysis((AccessorWithCodeAnalysis)(object)accessor);
        }

        public override void VisitArrayTypeReference<TTypeReference>(IArrayTypeReference<TTypeReference> arrayTypeReference)
        {
            visitor.VisitArrayTypeReferenceWithCodeAnalysis((ArrayTypeReferenceWithCodeAnalysis)(object)arrayTypeReference);
        }

        public override void VisitAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue>(
            IAttribute<TClassReference, TUnnamedAttributeValue, TNamedAttributeValue> attribute)
        {
            visitor.VisitAttributeWithCodeAnalysis((AttributeWithCodeAnalysis)attribute);
        }

        public override void VisitClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>(
            IClass<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor> @class)
        {
            visitor.VisitClassWithCodeAnalysis((ClassWithCodeAnalysis)(object)@class);
        }

        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            visitor.VisitClassReferenceWithCodeAnalysis((ClassReferenceWithCodeAnalysis)(object)classReference);
        }

        public override void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter> constructor)
        {
            visitor.VisitConstructorWithCodeAnalysis((ConstructorWithCodeAnalysis)(object)constructor);
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            visitor.VisitConversionOperatorWithCodeAnalysis((ConversionOperatorWithCodeAnalysis)(object)conversionOperator);
        }

        public override void VisitDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
        {
            visitor.VisitDelegateWithCodeAnalysis((DelegateWithCodeAnalysis)(object)@delegate);
        }

        public override void VisitDelegateReference<TGenericParameter>(IDelegateReference<TGenericParameter> delegateReference)
        {
            visitor.VisitDelegateReferenceWithCodeAnalysis((DelegateReferenceWithCodeAnalysis)(object)delegateReference);
        }

        public override void VisitDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            IDestructor<TAttributeGroup, TDeclaringType, TMethodBody> destructor)
        {
            visitor.VisitDestructorWithCodeAnalysis((DestructorWithCodeAnalysis)(object)destructor);
        }

        public override void VisitEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            visitor.VisitEnumWithCodeAnalysis((EnumWithCodeAnalysis)(object)@enum);
        }

        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
            visitor.VisitEnumMemberWithCodeAnalysis((EnumMemberWithCodeAnalysis)(object)enumMember);
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            visitor.VisitEnumReferenceWithCodeAnalysis((EnumReferenceWithCodeAnalysis)enumReference);
        }

        public override void VisitEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            visitor.VisitEventWithCodeAnalysis((EventWithCodeAnalysis)(object)@event);
        }

        public override void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            visitor.VisitEventPropertyWithCodeAnalysis((EventPropertyWithCodeAnalysis)(object)eventProperty);
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference> field)
        {
            visitor.VisitFieldWithCodeAnalysis((FieldWithCodeAnalysis)(object)field);
        }

        public override void VisitGenericParameter<TTypeReference>(IGenericParameter<TTypeReference> genericParameter)
        {
            visitor.VisitGenericParameterWithCodeAnalysis((GenericParameterWithCodeAnalysis)(object)genericParameter);
        }

        public override void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
        {
            visitor.VisitGenericParameterDeclarationWithCodeAnalysis((GenericParameterDeclarationWithCodeAnalysis)(object)genericParameterDeclaration);
        }

        public override void VisitGenericParameterReference(IGenericParameterReference genericParameterReference)
        {
            visitor.VisitGenericParameterReferenceWithCodeAnalysis((GenericParameterReferenceWithCodeAnalysis)genericParameterReference);
        }

        public override void VisitIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            visitor.VisitIndexerWithCodeAnalysis((IndexerWithCodeAnalysis)(object)indexer);
        }

        public override void VisitInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            visitor.VisitInterfaceWithCodeAnalysis((InterfaceWithCodeAnalysis)(object)@interface);
        }

        public override void VisitInterfaceReference<TGenericParameter>(IInterfaceReference<TGenericParameter> interfaceReference)
        {
            visitor.VisitInterfaceReferenceWithCodeAnalysis((InterfaceReferenceWithCodeAnalysis)(object)interfaceReference);
        }

        public override void VisitLoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            ILoadedDocument<TSolution, TProject, TDocument, TUsingDirective, TAttributeGroup, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> loadedDocument)
        {
            visitor.VisitAssemblyWithCodeAnalysis((AssemblyWithCodeAnalysis)(object)loadedDocument);
        }

        public override void VisitMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            visitor.VisitMethodWithCodeAnalysis((MethodWithCodeAnalysis)(object)method);
        }

        public override void VisitNamedAttributeValue(INamedAttributeValue namedAttributeValue)
        {
            visitor.VisitNamedAttributeValueWithCodeAnalysis((NamedAttributeValueWithCodeAnalysis)(object)namedAttributeValue);
        }

        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            visitor.VisitNamespaceWithCodeAnalysis((NamespaceWithCodeAnalysis)(object)@namespace);
        }

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TNestedDestructor> nestedClass)
        {
            visitor.VisitNestedClassWithCodeAnalysis((NestedClassWithCodeAnalysis)(object)nestedClass);
        }

        public override void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            visitor.VisitNestedDelegateWithCodeAnalysis((NestedDelegateWithCodeAnalysis)(object)nestedDelegate);
        }

        public override void VisitNestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody>(
            INestedDestructor<TAttributeGroup, TDeclaringType, TMethodBody> nestedDestructor)
        {
            visitor.VisitNestedDestructorWithCodeAnalysis((NestedDestructorWithCodeAnalysis)(object)nestedDestructor);
        }

        public override void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            visitor.VisitNestedEnumWithCodeAnalysis((NestedEnumWithCodeAnalysis)(object)nestedEnum);
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
            visitor.VisitNestedEnumMemberWithCodeAnalysis((NestedEnumMemberWithCodeAnalysis)(object)nestedEnumMember);
        }

        public override void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            visitor.VisitNestedInterfaceWithCodeAnalysis((NestedInterfaceWithCodeAnalysis)(object)@interface);
        }

        public override void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> nestedStruct)
        {
            visitor.VisitNestedStructWithCodeAnalysis((NestedStructWithCodeAnalysis)(object)nestedStruct);
        }

        public override void VisitNestedTypeReference<TTypeReference>(INestedTypeReference<TTypeReference> nestedTypeReference)
        {
            visitor.VisitNestedTypeReferenceWithCodeAnalysis((NestedTypeReferenceWithCodeAnalysis)(object)nestedTypeReference);
        }

        public override void VisitOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IOperatorOverload<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> operatorOverload)
        {
            visitor.VisitOperatorOverloadWithCodeAnalysis((OperatorOverloadWithCodeAnalysis)(object)operatorOverload);
        }

        public override void VisitParameter<TAttributeGroup, TTypeReference>(IParameter<TAttributeGroup, TTypeReference> parameter)
        {
            visitor.VisitParameterWithCodeAnalysis((ParameterWithCodeAnalysis)(object)parameter);
        }

        public override void VisitProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            visitor.VisitPropertyWithCodeAnalysis((PropertyWithCodeAnalysis)(object)property);
        }

        public override void VisitStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IStruct<TNamespace, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> @struct)
        {
            visitor.VisitStructWithCodeAnalysis((StructWithCodeAnalysis)(object)@struct);
        }

        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            visitor.VisitStructReferenceWithCodeAnalysis((StructReferenceWithCodeAnalysis)(object)structReference);
        }

        public override void VisitUnnamedAttributeValue(IUnnamedAttributeValue unnamedAttributeValue)
        {
            visitor.VisitUnnamedAttributeValueWithCodeAnalysis((UnnamedAttributeValueWithCodeAnalysis)unnamedAttributeValue);
        }

        public override void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecifiedTypeReference<TGenericParameter> unspecifiedTypeReference)
        {
            visitor.VisitUnspecifiedTypeReferenceWithCodeAnalysis((UnspecifiedTypeReferenceWithCodeAnalysis)(object)unspecifiedTypeReference);
        }
    }*/
}
