using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class MemberExpressionWithCodeAnalysis :
        EditableMemberExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<MemberAccessExpressionSyntax>,
        IInternalExpression
    {
        private readonly ExpressionNode<MemberExpressionWithCodeAnalysis, MemberAccessExpressionSyntax> node;
        private readonly CachedExpressionNode<MemberExpressionWithCodeAnalysis, MemberAccessExpressionSyntax> objectExpression;

        public MemberExpressionWithCodeAnalysis()
        {
            node = new ExpressionNode<MemberExpressionWithCodeAnalysis, MemberAccessExpressionSyntax>(this);
            objectExpression = new CachedExpressionNode<MemberExpressionWithCodeAnalysis, MemberAccessExpressionSyntax>(
                node,
                syntax => syntax.Expression,
                (parentSyntax, childSyntax) => parentSyntax.WithExpression(childSyntax));
        }

        public override string MemberName
        {
            get { return Syntax.Name.Identifier.Text; }
            set
            {
                MemberAccessExpressionSyntax syntax = Syntax;
                Syntax = syntax.WithName((SimpleNameSyntax)syntax.Name.WithName(value));
            }
        }

        public override IExpressionWithCodeAnalysis ObjectExpression
        {
            get { return objectExpression.Value; }
            set { objectExpression.Value = value; }
        }

        public MemberAccessExpressionSyntax Syntax
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
            set { Syntax = (MemberAccessExpressionSyntax)value; }
        }
    }
}
