using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.WithReflection
{
    public abstract class ReflectionVisitor
    {
        public virtual void VisitClassDeclaration(ClassDeclarationWithReflection node)
        {
        }

        public virtual void VisitClass(ClassWithReflection node)
        {
        }

        public virtual void VisitConstructor(ConstructorWithReflection node)
        {
        }

        public virtual void VisitConversionOperator(ConversionOperatorWithReflection node)
        {
        }

        public virtual void VisitDelegate(DelegateWithReflection node)
        {
        }

        public virtual void VisitDestructor(DestructorWithReflection node)
        {
        }

        public virtual void VisitDocument(DocumentWithReflection node)
        {
        }

        public virtual void VisitEnumMember(EnumMemberWithReflection node)
        {
        }

        public virtual void VisitEnum(EnumWithReflection node)
        {
        }

        public virtual void VisitEvent(EventWithReflection node)
        {
        }

        public virtual void VisitEventProperty(EventPropertyWithReflection node)
        {
        }

        public virtual void VisitField(FieldWithReflection node)
        {
        }

        public virtual void VisitIndexer(IndexerWithReflection node)
        {
        }

        public virtual void VisitInterfaceDeclaration(InterfaceDeclarationWithReflection node)
        {
        }

        public virtual void VisitInterface(InterfaceWithReflection node)
        {
        }

        public virtual void VisitMethod(MethodWithReflection node)
        {
        }

        public virtual void VisitNamespace(NamespaceWithReflection node)
        {
        }

        public virtual void VisitNestedClassDeclaration(NestedClassDeclarationWithReflection node)
        {
        }

        public virtual void VisitNestedClass(NestedClassWithReflection node)
        {
        }

        public virtual void VisitNestedDelegate(NestedDelegateWithReflection node)
        {
        }

        public virtual void VisitNestedDestructor(NestedDestructorWithReflection node)
        {
        }

        public virtual void VisitNestedEnum(NestedEnumWithReflection node)
        {
        }

        public virtual void VisitNestedEnumMember(NestedEnumMemberWithReflection node)
        {
        }

        public virtual void VisitNestedInterfaceDeclaration(NestedInterfaceDeclarationWithReflection node)
        {
        }

        public virtual void VisitNestedInterface(NestedInterfaceWithReflection node)
        {
        }

        public virtual void VisitNestedStructDeclaration(NestedStructDeclarationWithReflection node)
        {
        }

        public virtual void VisitNestedStruct(NestedStructWithReflection node)
        {
        }

        public virtual void VisitOperatorOverload(OperatorOverloadWithReflection node)
        {
        }

        public virtual Task VisitProjectAsync(ProjectWithReflection node)
        {
            return null;
        }

        public virtual void VisitProperty(PropertyWithReflection node)
        {
        }

        public virtual Task VisitSolutionAsync(SolutionWithReflection node)
        {
            return null;
        }

        public virtual void VisitStructDeclaration(StructDeclarationWithReflection node)
        {
        }

        public virtual void VisitStruct(StructWithReflection node)
        {
        }
    }
}
