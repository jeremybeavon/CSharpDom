namespace CSharpDom.CodeGeneration.Tree
{
    public class StatementVisitor
    {
        public virtual void Visit(AssignStatement node)
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

        public virtual void Visit(DocumentationComment node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(DoStatement node)
        {
            node.AcceptChildren(this);
        }
        
        public virtual void Visit(EmptyStatement node)
        {
            node.AcceptChildren(this);
        }
        
        public virtual void Visit(ExpressionStatement node)
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
        
        public virtual void Visit(GotoStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(IfStatement node)
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
        
        public virtual void Visit(MultiLineComment node)
        {
            node.AcceptChildren(this);
        }
        
        public virtual void Visit(RawStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(ReturnStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(SingleLineComment node)
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
        
        public virtual void Visit(UsingStatement node)
        {
            node.AcceptChildren(this);
        }

        public virtual void Visit(VariableDeclaration node)
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
