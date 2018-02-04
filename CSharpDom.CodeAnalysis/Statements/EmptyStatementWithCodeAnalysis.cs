using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class EmptyStatementWithCodeAnalysis :
        EditableEmptyStatement,
        IHasSyntax<EmptyStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<EmptyStatementWithCodeAnalysis, EmptyStatementSyntax> node;

        public EmptyStatementWithCodeAnalysis()
            : this(SyntaxFactory.EmptyStatement())
        {
        }

        internal EmptyStatementWithCodeAnalysis(EmptyStatementSyntax syntax)
        {
            node = new StatementNode<EmptyStatementWithCodeAnalysis, EmptyStatementSyntax>(this);
            if (syntax != null)
            {
                Syntax = syntax;
            }
        }

        public EmptyStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (EmptyStatementSyntax)value; }
        }
    }
}
