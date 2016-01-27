namespace CSharpDom.Reflection
{
    public interface IReflectionVisitor
    {
        void Visit(IVisitable<IReflectionVisitor> node);

        void VisitAccessorWithReflection(AccessorWithReflection accessor);

        void VisitArrayTypeReferenceWithReflection(ArrayTypeReferenceWithReflection arrayTypeReference);

        void VisitAssemblyWithReflection(AssemblyWithReflection assembly);

        void VisitAttributeWithReflection(AttributeWithReflection attribute);

        void VisitClassWithReflection(ClassWithReflection @class);

        void VisitClassReferenceWithReflection(ClassReferenceWithReflection classReference);

        void VisitConstructorWithReflection(ConstructorWithReflection constructor);

        void VisitConversionOperatorWithReflection(ConversionOperatorWithReflection conversionOperator);

        void VisitDelegateWithReflection(DelegateWithReflection @delegate);

        void VisitDelegateReferenceWithReflection(DelegateReferenceWithReflection delegateReference);

        void VisitDestructorWithReflection(DestructorWithReflection destructor);
        
        void VisitEnumWithReflection(EnumWithReflection @enum);

        void VisitEnumMemberWithReflection(EnumMemberWithReflection enumMember);

        void VisitEnumReferenceWithReflection(EnumReferenceWithReflection enumReference);

        void VisitEventWithReflection(EventWithReflection @event);

        void VisitEventPropertyWithReflection(EventPropertyWithReflection eventProperty);

        void VisitFieldWithReflection(FieldWithReflection field);

        void VisitGenericParameterWithReflection(GenericParameterWithReflection genericParameter);

        void VisitGenericParameterDeclarationWithReflection(GenericParameterDeclarationWithReflection genericParameterDeclaration);

        void VisitGenericParameterReferenceWithReflection(GenericParameterReferenceWithReflection genericParameterReference);

        void VisitIndexerWithReflection(IndexerWithReflection indexer);

        void VisitInterfaceWithReflection(InterfaceWithReflection @interface);

        void VisitInterfaceReferenceWithReflection(InterfaceReferenceWithReflection interfaceReference);
        
        void VisitMethodWithReflection(MethodWithReflection method);

        void VisitNamedAttributeValueWithReflection(NamedAttributeValueWithReflection namedAttributeValue);

        void VisitNamespaceWithReflection(NamespaceWithReflection @namespace);

        void VisitNestedClassWithReflection(NestedClassWithReflection nestedClass);

        void VisitNestedDelegateWithReflection(NestedDelegateWithReflection nestedDelegate);

        void VisitNestedDestructorWithReflection(NestedDestructorWithReflection nestedDestructor);

        void VisitNestedEnumWithReflection(NestedEnumWithReflection nestedEnum);

        void VisitNestedEnumMemberWithReflection(NestedEnumMemberWithReflection nestedEnumMember);

        void VisitNestedInterfaceWithReflection(NestedInterfaceWithReflection @interface);

        void VisitNestedStructWithReflection(NestedStructWithReflection nestedStruct);

        void VisitNestedTypeReferenceWithReflection(NestedTypeReferenceWithReflection nestedTypeReference);

        void VisitOperatorOverloadWithReflection(OperatorOverloadWithReflection operatorOverload);

        void VisitParameterWithReflection(ParameterWithReflection parameter);
        
        void VisitPropertyWithReflection(PropertyWithReflection property);
        
        void VisitStructWithReflection(StructWithReflection @struct);

        void VisitStructReferenceWithReflection(StructReferenceWithReflection structReference);

        void VisitUnnamedAttributeValueWithReflection(UnnamedAttributeValueWithReflection unnamedAttributeValue);

        void VisitUnspecifiedTypeReferenceWithReflection(UnspecifiedTypeReferenceWithReflection unspecificTypeReference);
    }
}
