using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class ArrayIndexExpressionWithCodeAnalysis :
        EditableArrayIndexExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<ElementAccessExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<ArrayIndexExpressionWithCodeAnalysis, ElementAccessExpressionSyntax> node;
        private readonly CachedExpressionNode<ArrayIndexExpressionWithCodeAnalysis, ElementAccessExpressionSyntax> array;
        private readonly ArgumentListWrapper<ArrayIndexExpressionWithCodeAnalysis, ElementAccessExpressionSyntax> indexes;

        internal ArrayIndexExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<ArrayIndexExpressionWithCodeAnalysis, ElementAccessExpressionSyntax>(this);
            array = new CachedExpressionNode<ArrayIndexExpressionWithCodeAnalysis, ElementAccessExpressionSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
            indexes = new ArgumentListWrapper<ArrayIndexExpressionWithCodeAnalysis, ElementAccessExpressionSyntax>(
                node,
                syntax => syntax.ArgumentList,
                (parentSyntax, childSyntax) => parentSyntax.WithArgumentList(childSyntax));
        }

        public override IExpressionWithCodeAnalysis Array
        {
            get { return array.Value; }
            set { array.Value = value; }
        }

        public override IList<IExpressionWithCodeAnalysis> Indexes
        {
            get { return indexes; }
            set { indexes.ReplaceList(value); }
        }

        public ElementAccessExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (ElementAccessExpressionSyntax)value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node => node;
    }
}
