using System;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class NullExpressionWithCodeAnalysis :
        EditableNullExpression,
        IHasSyntax<LiteralExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<NullExpressionWithCodeAnalysis, LiteralExpressionSyntax> node;

        public NullExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<NullExpressionWithCodeAnalysis, LiteralExpressionSyntax>(this);
        }

        public LiteralExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (LiteralExpressionSyntax)value; }
        }
    }
}
