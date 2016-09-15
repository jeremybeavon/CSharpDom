using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class UnaryOperatorExpressionWithCodeAnalysis :
        EditableUnaryOperatorExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<ExpressionSyntax>,
        IHasSyntax<PostfixUnaryExpressionSyntax>,
        IHasSyntax<PrefixUnaryExpressionSyntax>,
        IInternalExpression
    {
        private static readonly Map<SyntaxKind, UnaryOperatorExpressionType> prefixOperatorMap =
            new Map<SyntaxKind, UnaryOperatorExpressionType>()
            {
                { SyntaxKind.ExclamationToken, UnaryOperatorExpressionType.LogicalNot },
                { SyntaxKind.MinusToken, UnaryOperatorExpressionType.Minus },
                { SyntaxKind.MinusMinusToken, UnaryOperatorExpressionType.PreDecrement },
                { SyntaxKind.PlusToken, UnaryOperatorExpressionType.Plus },
                { SyntaxKind.PlusPlusToken, UnaryOperatorExpressionType.PreIncrement },
                { SyntaxKind.TildeToken, UnaryOperatorExpressionType.BitwiseNot }
            };
        private static readonly Map<SyntaxKind, UnaryOperatorExpressionType> postfixOperatorMap =
            new Map<SyntaxKind, UnaryOperatorExpressionType>()
            {
                { SyntaxKind.MinusMinusToken, UnaryOperatorExpressionType.PostDecrement },
                { SyntaxKind.PlusPlusToken, UnaryOperatorExpressionType.PostIncrement }
            };

        private readonly ExpressionNode<UnaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax> node;
        private readonly CachedExpressionNode<UnaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax> operand;

        public UnaryOperatorExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<UnaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax>(this);
            operand = new CachedExpressionNode<UnaryOperatorExpressionWithCodeAnalysis, ExpressionSyntax>(
                node,
                syntax => (syntax as PrefixUnaryExpressionSyntax)?.Operand ?? (syntax as PostfixUnaryExpressionSyntax)?.Operand,
                CreateOperand);
        }

        public override IExpressionWithCodeAnalysis Operand
        {
            get { return operand.Value; }
            set { operand.Value = value; }
        }

        public override UnaryOperatorExpressionType OperatorType
        {
            get
            {
                ExpressionSyntax syntax = Syntax;
                PrefixUnaryExpressionSyntax prefixSyntax = syntax as PrefixUnaryExpressionSyntax;
                if (prefixSyntax != null)
                {
                    return prefixOperatorMap[prefixSyntax.OperatorToken.Kind()];
                }

                PostfixUnaryExpressionSyntax postfixSyntax = syntax as PostfixUnaryExpressionSyntax;
                if (postfixSyntax != null)
                {
                    return postfixOperatorMap[postfixSyntax.OperatorToken.Kind()];
                }

                throw new NotSupportedException();
            }
            set
            {
                ExpressionSyntax syntax = Syntax;
                PrefixUnaryExpressionSyntax prefixSyntax = syntax as PrefixUnaryExpressionSyntax;
                PostfixUnaryExpressionSyntax postfixSyntax = syntax as PostfixUnaryExpressionSyntax;
                bool isSyntaxPrefix = prefixSyntax != null;
                if (value == UnaryOperatorExpressionType.PostDecrement || value == UnaryOperatorExpressionType.PostIncrement)
                {
                    Syntax = isSyntaxPrefix ?
                        SyntaxFactory.PostfixUnaryExpression(postfixOperatorMap[value], prefixSyntax.Operand) :
                        postfixSyntax.WithOperatorToken(SyntaxFactory.Token(postfixOperatorMap[value]));
                }
                else
                {
                    Syntax = isSyntaxPrefix ?
                        prefixSyntax.WithOperatorToken(SyntaxFactory.Token(prefixOperatorMap[value])) :
                        SyntaxFactory.PrefixUnaryExpression(prefixOperatorMap[value], postfixSyntax.Operand);
                }
            }
        }

        public PrefixUnaryExpressionSyntax PrefixSyntax
        {
            get { return Syntax as PrefixUnaryExpressionSyntax; }
            set { Syntax = value; }
        }

        public PostfixUnaryExpressionSyntax PostfixSyntax
        {
            get { return Syntax as PostfixUnaryExpressionSyntax; }
            set { Syntax = value; }
        }

        public ExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set
            {
                if (value != null && !(value is PrefixUnaryExpressionSyntax) && !(value is PostfixUnaryExpressionSyntax))
                {
                    throw new InvalidOperationException();
                }

                node.Syntax = value;
            }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }
        
        PrefixUnaryExpressionSyntax IHasSyntax<PrefixUnaryExpressionSyntax>.Syntax
        {
            get { return PrefixSyntax; }
            set { PrefixSyntax = value; }
        }

        PostfixUnaryExpressionSyntax IHasSyntax<PostfixUnaryExpressionSyntax>.Syntax
        {
            get { return PostfixSyntax; }
            set { PostfixSyntax = value; }
        }

        private ExpressionSyntax CreateOperand(ExpressionSyntax parentSyntax, ExpressionSyntax childSyntax)
        {
            return (ExpressionSyntax)(parentSyntax as PrefixUnaryExpressionSyntax)?.WithOperand(childSyntax) ??
                (parentSyntax as PostfixUnaryExpressionSyntax)?.WithOperand(childSyntax);
        }
    }
}
