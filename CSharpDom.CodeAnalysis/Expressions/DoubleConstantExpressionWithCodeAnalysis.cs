using CSharpDom.Editable.Expressions;
using System.Collections.Generic;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class DoubleConstantExpressionWithCodeAnalysis :
        EditableDoubleConstantExpression,
        IHasSyntax<LiteralExpressionSyntax>,
        IInternalExpression
    {


        public override double Constant
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public LiteralExpressionSyntax Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
