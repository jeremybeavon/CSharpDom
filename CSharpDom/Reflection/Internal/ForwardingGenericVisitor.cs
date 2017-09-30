using CSharpDom.BaseClasses;
using CSharpDom.Common;
using System;

namespace CSharpDom.Reflection.Internal
{
    internal class ForwardingGenericVisitor : AbstractGenericVisitor
    {
        private readonly IReflectionVisitor visitor;

        public ForwardingGenericVisitor(IReflectionVisitor visitor)
        {
            this.visitor = visitor;
        }

        public override void VisitAbstractAccessor<TAttributeGroup>(IAbstractAccessor<TAttributeGroup> accessor)
        {
            visitor.VisitAbstractAccessorWithReflection((AbstractAccessorWithReflection)(object)accessor);
        }

        public override void VisitAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IAbstractClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            visitor.VisitAbstractClassWithReflection((AbstractClassWithReflection)(object)@class);
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

        public override void VisitClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor>(
            IClass<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TClassReference, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor, TDestructor> @class)
        {
            visitor.VisitClassWithReflection((ClassWithReflection)(object)@class);
        }
        
        public override void VisitClassReference<TGenericParameter>(IClassReference<TGenericParameter> classReference)
        {
            visitor.VisitClassReferenceWithReflection((ClassReferenceWithReflection)(object)classReference);
        }

        public override void VisitClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody>(
            IClassConstructor<TAttributeGroup, TDeclaringType, TParameter, TMethodBody> constructor)
        {
            visitor.VisitClassConstructorWithReflection((ClassConstructorWithReflection)(object)constructor);
        }

        public override void VisitClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference>(
            IClassEvent<TAttributeGroup, TDeclaringType, TDelegateReference> @event)
        {
            visitor.VisitClassEventWithReflection((ClassEventWithReflection)(object)@event);
        }

        public override void VisitClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>(
            IClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> eventProperty)
        {
            visitor.VisitClassEventPropertyWithReflection((ClassEventPropertyWithReflection)(object)eventProperty);
        }

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            visitor.VisitClassFieldWithReflection((ClassFieldWithReflection)(object)field);
        }

        public override void VisitClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor>(
            IClassIndexer<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TAccessor> indexer)
        {
            visitor.VisitClassIndexerWithReflection((ClassIndexerWithReflection)(object)indexer);
        }

        public override void VisitClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody>(
            IClassMethod<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter, TMethodBody> method)
        {
            visitor.VisitClassMethodWithReflection((ClassMethodWithReflection)(object)method);
        }

        public override void VisitClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor>(
            IClassNestedClass<TAttributeGroup, TDeclaringType, TGenericParameter, TClassReference, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct, TDestructor> nestedClass)
        {
            visitor.VisitClassNestedClassWithReflection((ClassNestedClassWithReflection)(object)nestedClass);
        }

        public override void VisitClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter>(
            IClassNestedDelegate<TAttributeGroup, TDeclaringType, TGenericParameter, TTypeReference, TParameter> nestedDelegate)
        {
            visitor.VisitClassNestedDelegateWithReflection((ClassNestedDelegateWithReflection)(object)nestedDelegate);
        }

        public override void VisitClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember>(
            IClassNestedEnum<TAttributeGroup, TDeclaringType, TNestedEnumMember> nestedEnum)
        {
            visitor.VisitClassNestedEnumWithReflection((ClassNestedEnumWithReflection)(object)nestedEnum);
        }

        public override void VisitClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IClassNestedInterface<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
        {
            visitor.VisitClassNestedInterfaceWithReflection((ClassNestedInterfaceWithReflection)(object)@interface);
        }

        public override void VisitClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct>(
            IClassNestedStruct<TAttributeGroup, TDeclaringType, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod, TField, TConstructor, TEventProperty, TOperatorOverload, TConversionOperator, TNestedClass, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStruct> nestedStruct)
        {
            visitor.VisitClassNestedStructWithReflection((ClassNestedStructWithReflection)(object)nestedStruct);
        }

        public override void VisitClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
            visitor.VisitClassPropertyWithReflection((ClassPropertyWithReflection)(object)property);
        }

        public override void VisitConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody>(
            IConversionOperator<TAttributeGroup, TDeclaringType, TTypeReference, TParameter, TMethodBody> conversionOperator)
        {
            visitor.VisitConversionOperatorWithReflection((ConversionOperatorWithReflection)(object)conversionOperator);
        }

        public override void VisitDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter>(
            IDelegate<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TTypeReference, TParameter> @delegate)
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

        public override void VisitEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember>(
            IEnum<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TEnumMember> @enum)
        {
            visitor.VisitEnumWithReflection((EnumWithReflection)(object)@enum);
        }
        
        public override void VisitEnumMember<TAttributeGroup, TDeclaringType>(
            IEnumMember<TAttributeGroup, TDeclaringType> enumMember)
        {
            visitor.VisitEnumMemberWithReflection((EnumMemberWithReflection)(object)enumMember);
        }

        public override void VisitEnumReference(IEnumReference enumReference)
        {
            visitor.VisitEnumReferenceWithReflection((EnumReferenceWithReflection)enumReference);
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

        public override void VisitInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod>(
            IInterface<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEvent, TProperty, TIndexer, TMethod> @interface)
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

        public override void VisitNamedAttributeValue<TExpression>(
            INamedAttributeValue<TExpression> namedAttributeValue)
        {
            visitor.VisitNamedAttributeValueWithReflection((NamedAttributeValueWithReflection)(object)namedAttributeValue);
        }
        
        public override void VisitNamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct>(
            INamespace<TUsingDirective, TNamespace, TClass, TDelegate, TEnum, TInterface, TStruct> @namespace)
        {
            visitor.VisitNamespaceWithReflection((NamespaceWithReflection)(object)@namespace);
        }

        public override void VisitNestedEnumMember<TAttributeGroup, TDeclaringType>(
            INestedEnumMember<TAttributeGroup, TDeclaringType> nestedEnumMember)
        {
            visitor.VisitNestedEnumMemberWithReflection((NestedEnumMemberWithReflection)(object)nestedEnumMember);
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

        public override void VisitStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor>(
            IStruct<TNamespace, TDocument, TProject, TSolution, TAttributeGroup, TGenericParameter, TInterfaceReference, TEventCollection, TPropertyCollection, TIndexerCollection, TMethodCollection, TFieldCollection, TConstructor, TOperatorOverload, TConversionOperator, TNestedClassCollection, TNestedDelegate, TNestedEnum, TNestedInterface, TNestedStructCollection, TStaticConstructor> @struct)
        {
            visitor.VisitStructWithReflection((StructWithReflection)(object)@struct);
        }
        
        public override void VisitStructReference<TGenericParameter>(IStructReference<TGenericParameter> structReference)
        {
            visitor.VisitStructReferenceWithReflection((StructReferenceWithReflection)(object)structReference);
        }

        public override void VisitUnnamedAttributeValue<TExpression>(IUnnamedAttributeValue<TExpression> unnamedAttributeValue)
        {
            visitor.VisitUnnamedAttributeValueWithReflection((UnnamedAttributeValueWithReflection)(object)unnamedAttributeValue);
        }
        
        public override void VisitUnspecifiedTypeReference<TGenericParameter>(
            IUnspecifiedTypeReference<TGenericParameter> unspecifiedTypeReference)
        {
            visitor.VisitUnspecifiedTypeReferenceWithReflection((UnspecifiedTypeReferenceWithReflection)(object)unspecifiedTypeReference);
        }
    }
}
