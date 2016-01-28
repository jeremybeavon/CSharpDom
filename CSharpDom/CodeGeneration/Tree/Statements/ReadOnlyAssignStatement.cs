using CSharpDom.BaseClasses.Statements;
using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyAssignStatement : AbstractExpressionStatement<ReadOnlyAssignStatement>,
        IBinaryOperatorExpression<ReadOnlyExpressionStatement>
    {
        private readonly ReadOnlyExpressionStatement left;
        private readonly ReadOnlyExpressionStatement right;

        public ReadOnlyAssignStatement(AssignStatement assignStatement)
        {
            left = new ReadOnlyExpressionStatement(assignStatement.Left);
            right = new ReadOnlyExpressionStatement(assignStatement.Right);
        }

        public override ReadOnlyAssignStatement Expression
        {
            get { return this; }
        }

        public ReadOnlyExpressionStatement Left
        {
            get { return left; }
        }

        public BinaryOperatorExpressionType OperatorType
        {
            get { return BinaryOperatorExpressionType.Assign; }
        }

        public ReadOnlyExpressionStatement Right
        {
            get { return right; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            visitor.VisitBinaryOperatorExpression(this);
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            GenericExpressionVisitor.VisitBinaryOperatorExpressionChildren(this, visitor);
        }
    }
}
