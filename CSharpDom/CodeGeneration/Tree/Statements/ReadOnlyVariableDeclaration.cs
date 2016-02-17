using CSharpDom.Common.Expressions;

namespace CSharpDom.CodeGeneration.Tree.Statements
{
    public sealed class ReadOnlyVariableDeclaration : IBinaryOperatorExpression<ReadOnlyVariableDeclarationExpression>
    {
        public ReadOnlyVariableDeclaration(VariableDeclaration variableDeclaration)
        {
            Left = new ReadOnlyVariableDeclarationExpression(variableDeclaration.Name);
            if (variableDeclaration.InitialValue != null)
            {
                Right = new ReadOnlyVariableDeclarationExpression(new ReadOnlyExpressionStatement(variableDeclaration.InitialValue));
            }
        }

        public ReadOnlyVariableDeclarationExpression Left { get; private set; }

        public BinaryOperatorExpressionType OperatorType
        {
            get { return BinaryOperatorExpressionType.Assign; }
        }

        public ReadOnlyVariableDeclarationExpression Right { get; private set; }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            if (Right == null)
            {
                Left.Accept(visitor);
            }
            else
            {
                visitor.VisitBinaryOperatorExpression(this);
            }
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            if (Right == null)
            {
                Left.AcceptChildren(visitor);
            }
            else
            {
                GenericExpressionVisitor.VisitBinaryOperatorExpressionChildren(this, visitor);
            }
        }
    }
}
