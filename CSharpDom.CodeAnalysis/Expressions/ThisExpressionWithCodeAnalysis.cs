using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class ThisExpressionWithCodeAnalysis : EditableThisExpression,
        IHasSyntax<ThisExpressionSyntax>,
        IHasNode<ThisExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<ThisExpressionWithCodeAnalysis, ThisExpressionSyntax> node;

        public ThisExpressionWithCodeAnalysis()
            : this(SyntaxFactory.ThisExpression())
        {
        }

        internal ThisExpressionWithCodeAnalysis(ThisExpressionSyntax syntax)
        {
            node = new ExpressionNode<ThisExpressionWithCodeAnalysis, ThisExpressionSyntax>(this);
            if (syntax != null)
            {
                Syntax = syntax;
            }
        }

        public ThisExpressionSyntax Syntax { get => node.Syntax; set => node.Syntax = value; }

        INode<ThisExpressionSyntax> IHasNode<ThisExpressionSyntax>.Node => node;

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => node;

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get => Syntax;
            set => Syntax = (ThisExpressionSyntax)value;
        }
    }
}
