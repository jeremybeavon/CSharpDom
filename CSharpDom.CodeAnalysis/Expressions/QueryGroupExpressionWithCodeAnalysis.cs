using CSharpDom.Common;
using CSharpDom.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryGroupExpressionWithCodeAnalysis :
        EditableQueryGroupExpression<IExpressionWithCodeAnalysis, QueryIntoExpressionWithCodeAnalysis>,
        IHasSyntax<GroupClauseSyntax>
    {
        private readonly Node<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax> node;
        private readonly CachedExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax> byExpression;
        private readonly CachedExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax> groupExpression;
       
        internal QueryGroupExpressionWithCodeAnalysis()
        {
            node = new Node<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax>(this);
            byExpression = new CachedExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax>(
                node,
                syntax => syntax.ByExpression,
                (parentSyntax, childSyntax) => parentSyntax.WithByExpression(childSyntax));
            groupExpression = new CachedExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax>(
                node,
                syntax => syntax.GroupExpression,
                (parentSyntax, childSyntax) => parentSyntax.WithGroupExpression(childSyntax));
        }

        public override IExpressionWithCodeAnalysis ByExpression
        {
            get { return byExpression.Value; }
            set { byExpression.Value = value; }
        }

        public override IExpressionWithCodeAnalysis GroupExpression
        {
            get { return groupExpression.Value; }
            set { groupExpression.Value = value; }
        }

        public override QueryIntoExpressionWithCodeAnalysis IntoExpression
        {
            get { return node.GetParentNode<QueryFromExpressionWithCodeAnalysis>().IntoExpression; }
            set { node.GetParentNode<QueryFromExpressionWithCodeAnalysis>().IntoExpression = value; }
        }

        public GroupClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }
    }
}
