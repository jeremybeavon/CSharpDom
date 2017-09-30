using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface IReflectionVisitor
    {
        void Visit(IVisitable<IReflectionVisitor> node);

        void VisitAbstractAccessorWithReflection(AbstractAccessorWithReflection accessor);

        void VisitAbstractClassWithReflection(AbstractClassWithReflection @class);

        void VisitAccessorWithReflection(AccessorWithReflection accessor);

        void VisitArrayTypeReferenceWithReflection(ArrayTypeReferenceWithReflection arrayTypeReference);

        void VisitAssemblyWithReflection(AssemblyWithReflection assembly);

        void VisitAttributeWithReflection(AttributeWithReflection attribute);

        void VisitClassWithReflection(ClassWithReflection @class);

        void VisitClassConstructorWithReflection(ClassConstructorWithReflection constructor);

        void VisitClassEventPropertyWithReflection(ClassEventPropertyWithReflection eventProperty);

        void VisitClassEventWithReflection(ClassEventWithReflection @event);

        void VisitClassFieldWithReflection(ClassFieldWithReflection field);

        void VisitClassIndexerWithReflection(ClassIndexerWithReflection indexer);

        void VisitClassMethodWithReflection(ClassMethodWithReflection method);

        void VisitClassNestedClassWithReflection(ClassNestedClassWithReflection nestedClass);

        void VisitClassNestedDelegateWithReflection(ClassNestedDelegateWithReflection nestedDelegate);

        void VisitClassNestedEnumWithReflection(ClassNestedEnumWithReflection nestedEnum);

        void VisitClassNestedInterfaceWithReflection(ClassNestedInterfaceWithReflection @interface);

        void VisitClassNestedStructWithReflection(ClassNestedStructWithReflection nestedStruct);

        void VisitClassReferenceWithReflection(ClassReferenceWithReflection classReference);

        void VisitClassPropertyWithReflection(ClassPropertyWithReflection property);

        void VisitConversionOperatorWithReflection(ConversionOperatorWithReflection conversionOperator);

        void VisitDelegateWithReflection(DelegateWithReflection @delegate);

        void VisitDelegateReferenceWithReflection(DelegateReferenceWithReflection delegateReference);

        void VisitDestructorWithReflection(DestructorWithReflection destructor);
        
        void VisitEnumWithReflection(EnumWithReflection @enum);

        void VisitEnumMemberWithReflection(EnumMemberWithReflection enumMember);

        void VisitEnumReferenceWithReflection(EnumReferenceWithReflection enumReference);

        void VisitGenericParameterDeclarationWithReflection(GenericParameterDeclarationWithReflection genericParameterDeclaration);

        void VisitGenericParameterReferenceWithReflection(GenericParameterReferenceWithReflection genericParameterReference);

        void VisitInterfaceWithReflection(InterfaceWithReflection @interface);

        void VisitInterfaceReferenceWithReflection(InterfaceReferenceWithReflection interfaceReference);

        void VisitNamedAttributeValueWithReflection(NamedAttributeValueWithReflection namedAttributeValue);

        void VisitNamespaceWithReflection(NamespaceWithReflection @namespace);

        void VisitNestedEnumMemberWithReflection(NestedEnumMemberWithReflection nestedEnumMember);

        void VisitNestedTypeReferenceWithReflection(NestedTypeReferenceWithReflection nestedTypeReference);

        void VisitOperatorOverloadWithReflection(OperatorOverloadWithReflection operatorOverload);

        void VisitParameterWithReflection(ParameterWithReflection parameter);
        
        void VisitStructWithReflection(StructWithReflection @struct);

        void VisitStructReferenceWithReflection(StructReferenceWithReflection structReference);

        void VisitUnnamedAttributeValueWithReflection(UnnamedAttributeValueWithReflection unnamedAttributeValue);

        void VisitUnspecifiedTypeReferenceWithReflection(UnspecifiedTypeReferenceWithReflection unspecificTypeReference);
    }
}
