using CSharpDom.BaseClasses.Editable.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Statements
{
    public sealed class DoStatementWithCodeAnalysis :
        EditableDoStatement<IExpressionWithCodeAnalysis, IStatementWithCodeAnalysis>,
        IHasSyntax<DoStatementSyntax>,
        IHasNode<DoStatementSyntax>,
        IInternalStatement
    {
        private readonly StatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax> node;
        private readonly CachedExpressionNode<DoStatementWithCodeAnalysis, DoStatementSyntax> condition;
        private readonly CachedStatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax> statement;

        public DoStatementWithCodeAnalysis(IExpressionWithCodeAnalysis condition, IStatementWithCodeAnalysis statement)
            : this()
        {
            Syntax = SyntaxFactory.DoStatement(statement.Syntax, condition.Syntax);
        }

        internal DoStatementWithCodeAnalysis()
        {
            node = new StatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax>(this);
            condition = new CachedExpressionNode<DoStatementWithCodeAnalysis, DoStatementSyntax>(
                node,
                syntax => syntax.Condition,
                (parentSyntax, childSyntax) => parentSyntax.WithCondition(childSyntax));
            statement = new CachedStatementNode<DoStatementWithCodeAnalysis, DoStatementSyntax>(
                node,
                syntax => syntax.Statement,
                (parentSyntax, childSyntax) => parentSyntax.WithStatement(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Condition
        {
            get { return condition.Value; }
            set { condition.Value = value; }
        }

        public override IStatementWithCodeAnalysis Statement
        {
            get { return statement.Value; }
            set { statement.Value = value; }
        }

        public DoStatementSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
        
        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (DoStatementSyntax)value; }
        }

        INode<StatementSyntax> IHasNode<StatementSyntax>.Node
        {
            get { return node; }
        }

        INode<DoStatementSyntax> IHasNode<DoStatementSyntax>.Node => node;
    }
}
