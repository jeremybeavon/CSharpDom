using CSharpDom.BaseClasses.Editable.Expressions;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class StringConstantExpressionWithCodeAnalysis :
        EditableStringConstantExpression,
        IInternalLiteralExpression
    {
        private readonly LiteralExpression<string> expression;

        internal StringConstantExpressionWithCodeAnalysis()
        {
            expression = new LiteralExpression<string>();
        }

        public override string Constant
        {
            get { return expression.Constant; }
            set
            {
                bool hasAtSymbol = HasAtSymbol;

                expression.Constant = value;
                throw new System.NotImplementedException();
            }
        }

        public override bool HasAtSymbol
        {
            get { return Syntax.Token.Text.StartsWith("@"); }
            set
            {
                throw new System.NotImplementedException();
            }
        }

        public LiteralExpressionSyntax Syntax
        {
            get { return expression.Syntax; }
            set { expression.Syntax = value; }
        }
        
        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return expression.ExpressionSyntax; }
            set { expression.ExpressionSyntax = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => expression.Node;
    }
}
