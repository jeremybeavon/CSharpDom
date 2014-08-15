using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharpDom
{
    internal abstract class NodeVisitor
    {
        public static void VisitCollection<T>(IEnumerable<T> collection, Action<T> visitAction)
        {
            foreach (T item in collection)
            {
                visitAction(item);
            }
        }

        public virtual void DefaultVisit(AbstractNode node)
        {
            node.Accept(this);
        }

        public virtual Task DefaultVisitAsync(AbstractAsyncNode node)
        {
            return node.AcceptAsync(this);
        }

        public virtual void VisitClassDeclaration(ClassDeclarationNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitClass(ClassNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitConstructor(ConstructorNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitConversionOperator(ConversionOperatorNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDelegate(DelegateNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDestructor(DestructorNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitDocument(DocumentNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEnumMember(EnumMemberNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEnum(EnumNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEvent(EventNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitEventProperty(EventPropertyNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitField(FieldNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitIndexer(IndexerNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitInterface(InterfaceNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitMethod(MethodNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNamespace(NamespaceNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedClassDeclaration(ClassDeclarationNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedClass(ClassNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedDelegate(DelegateNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedDestructor(DestructorNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedEnum(EnumNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedEnumMember(EnumMemberNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedInterfaceDeclaration(InterfaceDeclarationNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedInterface(InterfaceNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedStructDeclaration(StructDeclarationNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitNestedStruct(StructNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitOperatorOverload(OperatorOverloadNode node)
        {
            DefaultVisit(node);
        }

        public virtual Task VisitProjectAsync(ProjectNode node)
        {
            return DefaultVisitAsync(node);
        }

        public virtual void VisitProperty(PropertyNode node)
        {
            DefaultVisit(node);
        }

        public virtual Task VisitSolutionAsync(SolutionNode node)
        {
            return DefaultVisitAsync(node);
        }

        public virtual void VisitStructDeclaration(StructDeclarationNode node)
        {
            DefaultVisit(node);
        }

        public virtual void VisitStruct(StructNode node)
        {
            DefaultVisit(node);
        }
    }
}
