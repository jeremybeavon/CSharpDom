using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common.Expressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal sealed class LiteralExpression<T> : IInternalLiteralExpression
    {
        private readonly ExpressionNode<LiteralExpression<T>, LiteralExpressionSyntax> node;

        internal LiteralExpression()
        {
            node = new ExpressionNode<LiteralExpression<T>, LiteralExpressionSyntax>(this);
        }

        public T Constant
        {
            get { return (T)Syntax.Token.Value; }
            set
            {
                string constant = value.ToString();
                Syntax = Syntax.WithToken(constant, constant);
            }
        }

        public LiteralExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public ExpressionSyntax ExpressionSyntax
        {
            get { return Syntax; }
            set { Syntax = (LiteralExpressionSyntax)value; }
        }

        public INode<ExpressionSyntax> Node => node;

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return ExpressionSyntax; }
            set { ExpressionSyntax = value; }
        }

        public void Accept(IGenericExpressionVisitor visitor)
        {
            throw new NotSupportedException();
        }

        public void AcceptChildren(IGenericExpressionVisitor visitor)
        {
            throw new NotSupportedException();
        }
    }
}
