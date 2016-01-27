using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Reflection
{
    public abstract class AbstractReflectionVisitor : IReflectionVisitor
    {
        public virtual void Visit(IVisitable<IReflectionVisitor> node)
        {
            node.AcceptChildren(this);
        }

        public virtual void VisitAccessorWithReflection(AccessorWithReflection accessor)
        {
            Visit(accessor);
        }

        public virtual void VisitArrayTypeReferenceWithReflection(ArrayTypeReferenceWithReflection arrayTypeReference)
        {
            Visit(arrayTypeReference);
        }

        public virtual void VisitAssemblyWithReflection(AssemblyWithReflection assembly)
        {
            Visit(assembly);
        }

        public virtual void VisitAttributeWithReflection(AttributeWithReflection attribute)
        {
            Visit(attribute);
        }

        public virtual void VisitClassReferenceWithReflection(ClassReferenceWithReflection classReference)
        {
            Visit(classReference);
        }

        public virtual void VisitClassWithReflection(ClassWithReflection @class)
        {
            Visit(@class);
        }

        public virtual void VisitConstructorWithReflection(ConstructorWithReflection constructor)
        {
            Visit(constructor);
        }

        public virtual void VisitConversionOperatorWithReflection(ConversionOperatorWithReflection conversionOperator)
        {
            Visit(conversionOperator);
        }

        public virtual void VisitDelegateReferenceWithReflection(DelegateReferenceWithReflection delegateReference)
        {
            Visit(delegateReference);
        }

        public virtual void VisitDelegateWithReflection(DelegateWithReflection @delegate)
        {
            Visit(@delegate);
        }

        public virtual void VisitDestructorWithReflection(DestructorWithReflection destructor)
        {
            Visit(destructor);
        }

        public virtual void VisitEnumMemberWithReflection(EnumMemberWithReflection enumMember)
        {
            Visit(enumMember);
        }

        public virtual void VisitEnumReferenceWithReflection(EnumReferenceWithReflection enumReference)
        {
            Visit(enumReference);
        }

        public virtual void VisitEnumWithReflection(EnumWithReflection @enum)
        {
            Visit(@enum);
        }

        public virtual void VisitEventPropertyWithReflection(EventPropertyWithReflection eventProperty)
        {
            Visit(eventProperty);
        }

        public virtual void VisitEventWithReflection(EventWithReflection @event)
        {
            Visit(@event);
        }

        public virtual void VisitFieldWithReflection(FieldWithReflection field)
        {
            Visit(field);
        }

        public virtual void VisitGenericParameterDeclarationWithReflection(GenericParameterDeclarationWithReflection genericParameterDeclaration)
        {
            Visit(genericParameterDeclaration);
        }

        public virtual void VisitGenericParameterReferenceWithReflection(GenericParameterReferenceWithReflection genericParameterReference)
        {
            Visit(genericParameterReference);
        }

        public virtual void VisitGenericParameterWithReflection(GenericParameterWithReflection genericParameter)
        {
            Visit(genericParameter);
        }

        public virtual void VisitIndexerWithReflection(IndexerWithReflection indexer)
        {
            Visit(indexer);
        }

        public virtual void VisitInterfaceReferenceWithReflection(InterfaceReferenceWithReflection interfaceReference)
        {
            Visit(interfaceReference);
        }

        public virtual void VisitInterfaceWithReflection(InterfaceWithReflection @interface)
        {
            Visit(@interface);
        }

        public virtual void VisitMethodWithReflection(MethodWithReflection method)
        {
            Visit(method);
        }

        public virtual void VisitNamedAttributeValueWithReflection(NamedAttributeValueWithReflection namedAttributeValue)
        {
            Visit(namedAttributeValue);
        }

        public virtual void VisitNamespaceWithReflection(NamespaceWithReflection @namespace)
        {
            Visit(@namespace);
        }

        public virtual void VisitNestedClassWithReflection(NestedClassWithReflection nestedClass)
        {
            Visit(nestedClass);
        }

        public virtual void VisitNestedDelegateWithReflection(NestedDelegateWithReflection nestedDelegate)
        {
            Visit(nestedDelegate);
        }

        public virtual void VisitNestedDestructorWithReflection(NestedDestructorWithReflection nestedDestructor)
        {
            Visit(nestedDestructor);
        }

        public virtual void VisitNestedEnumMemberWithReflection(NestedEnumMemberWithReflection nestedEnumMember)
        {
            Visit(nestedEnumMember);
        }

        public virtual void VisitNestedEnumWithReflection(NestedEnumWithReflection nestedEnum)
        {
            Visit(nestedEnum);
        }

        public virtual void VisitNestedInterfaceWithReflection(NestedInterfaceWithReflection @interface)
        {
            Visit(@interface);
        }

        public virtual void VisitNestedStructWithReflection(NestedStructWithReflection nestedStruct)
        {
            Visit(nestedStruct);
        }

        public virtual void VisitNestedTypeReferenceWithReflection(NestedTypeReferenceWithReflection nestedTypeReference)
        {
            Visit(nestedTypeReference);
        }

        public virtual void VisitOperatorOverloadWithReflection(OperatorOverloadWithReflection operatorOverload)
        {
            Visit(operatorOverload);
        }

        public virtual void VisitParameterWithReflection(ParameterWithReflection parameter)
        {
            Visit(parameter);
        }

        public virtual void VisitPropertyWithReflection(PropertyWithReflection property)
        {
            Visit(property);
        }

        public virtual void VisitStructReferenceWithReflection(StructReferenceWithReflection structReference)
        {
            Visit(structReference);
        }

        public virtual void VisitStructWithReflection(StructWithReflection @struct)
        {
            Visit(@struct);
        }

        public virtual void VisitUnnamedAttributeValueWithReflection(UnnamedAttributeValueWithReflection unnamedAttributeValue)
        {
            Visit(unnamedAttributeValue);
        }

        public virtual void VisitUnspecifiedTypeReferenceWithReflection(UnspecifiedTypeReferenceWithReflection unspecificTypeReference)
        {
            Visit(unspecificTypeReference);
        }
    }
}
