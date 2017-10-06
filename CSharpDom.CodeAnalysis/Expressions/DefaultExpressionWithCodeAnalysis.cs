using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class DefaultExpressionWithCodeAnalysis :
        EditableDefaultExpression<ITypeReferenceWithCodeAnalysis>,
        IHasSyntax<DefaultExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<DefaultExpressionWithCodeAnalysis, DefaultExpressionSyntax> node;
        private readonly CachedTypeReferenceNode<DefaultExpressionWithCodeAnalysis, DefaultExpressionSyntax> type;

        public DefaultExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<DefaultExpressionWithCodeAnalysis, DefaultExpressionSyntax>(this);
            type = new CachedTypeReferenceNode<DefaultExpressionWithCodeAnalysis, DefaultExpressionSyntax>(
                node,
                syntax => syntax.Type,
                (parentSyntax, childSyntax) => parentSyntax.WithType(childSyntax));
        }

        public DefaultExpressionSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        public override ITypeReferenceWithCodeAnalysis Type
        {
            get { return type.Value; }
            set { type.Value = value; }
        }

        INode<ExpressionSyntax> IHasNode<ExpressionSyntax>.Node
        {
            get { return node; }
        }

        ExpressionSyntax IHasSyntax<ExpressionSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (DefaultExpressionSyntax)value; }
        }
    }
}
