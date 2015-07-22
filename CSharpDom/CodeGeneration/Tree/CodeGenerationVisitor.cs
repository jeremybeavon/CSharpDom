using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public class CodeGenerationVisitor
    {
        public virtual void Visit(AssignStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(BinaryOperator node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(BlockStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(CatchStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(Class node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassBody node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassEvent node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassFieldDeclaration node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassIndexer node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassMethod node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassNestedClass node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassNestedDelegate node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassNestedEnum node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassNestedInterface node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassNestedStruct node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassReference node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassProperty node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ClassPropertyAccessor node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(CodeGenerationFile node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ConversionOperator node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(Delegate node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(DelegateReference node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(DocumentationComment node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(DoStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(EmptyClassPropertyAccessors node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(EmptyStructPropertyAccessors node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(Enum node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(EnumField node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(EventAccessors node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ExpressionStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(Field node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(FinallyStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ForeachStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ForStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(GenericParameter node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(GenericParameterReference node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(GotoStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(IfStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(Interface node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(InterfaceBody node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(InterfaceEvent node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(InterfaceMethod node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(InterfaceProperty node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(InterfaceReference node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(LabelReference node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(LabelStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(LockStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(MethodParameter node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(MultiLineComment node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(Namespace node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(RawStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(SingleLineComment node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(Struct node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructBody node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructEvent node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructFieldDeclaration node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructIndexer node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructMethod node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructNestedClass node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructNestedDelegate node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructNestedEnum node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructNestedInterface node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructNestedStruct node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructProperty node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(StructPropertyAccessor node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(SwitchCaseStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(SwitchStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(TryStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(TypeReference node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(UnaryOperator node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(UsingDeclaration node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(UsingStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(VariableDeclarationStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(WhileStatement node)
        {
            node.AcceptChildren(this);
        }
    }
}
