using System.Linq.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed partial class LinqBuilder
    {
        public override ILinqExpressionMapping VisitBinaryExpression(BinaryExpressionSyntax node)
        {
            ILinqExpressionMapping left = node.Left.Accept(this);
            ILinqExpressionMapping right = node.Right.Accept(this);
            return new BinaryExpression(left, right, node);
        }

        public override ILinqExpressionMapping VisitIdentifierName(IdentifierNameSyntax node)
        {
            string name = node.Identifier.Text;
            SymbolInfo symbolInfo = semanticModel.GetSymbolInfo(node);
            switch (symbolInfo.Symbol.Kind)
            {
                case SymbolKind.Local:
                    return new LocalVariableReferenceExpression(localVariables.GetLocalVariable(name), node);
                case SymbolKind.Parameter:
                    return new ParameterReferenceExpression(parameters[name], node);
                case SymbolKind.NamedType:
                    return null;
            }

            return base.VisitIdentifierName(node);
        }

        public override ILinqExpressionMapping VisitLiteralExpression(LiteralExpressionSyntax node)
        {
            return new ConstantExpression(Expression.Constant(semanticModel.GetConstantValue(node)), node);
        }

        public override ILinqExpressionMapping VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            ILinqExpressionMapping expression = node.Expression.Accept(this);
            return base.VisitMemberAccessExpression(node);
        }

        public override ILinqExpressionMapping VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
        {
            return node.Expression.Accept(this);
        }

        public override ILinqExpressionMapping VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
        {
            return new UnaryExpression(node.Operand.Accept(this), node);
        }

        public override ILinqExpressionMapping VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
        {
            return new PostfixUnaryExpression(node.Operand.Accept(this), node);
        }
    }
}
