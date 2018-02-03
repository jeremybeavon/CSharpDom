using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryGroupIntoExpressionWithCodeAnalysis :
        EditableQueryGroupIntoExpression<IExpressionWithCodeAnalysis, QueryIntoExpressionWithCodeAnalysis>,
        IHasSyntax<GroupClauseSyntax>,
        IHasNode<GroupClauseSyntax>,
        IInternalQueryEndExpression
    {
        private readonly QueryEndExpressionNode<QueryGroupIntoExpressionWithCodeAnalysis, GroupClauseSyntax> node;
        private readonly CachedExpressionNode<QueryGroupIntoExpressionWithCodeAnalysis, GroupClauseSyntax> byExpression;
        private readonly CachedExpressionNode<QueryGroupIntoExpressionWithCodeAnalysis, GroupClauseSyntax> groupExpression;
       
        internal QueryGroupIntoExpressionWithCodeAnalysis()
        {
            node = new QueryEndExpressionNode<QueryGroupIntoExpressionWithCodeAnalysis, GroupClauseSyntax>(this);
            byExpression = new CachedExpressionNode<QueryGroupIntoExpressionWithCodeAnalysis, GroupClauseSyntax>(
                node,
                syntax => syntax.ByExpression,
                (parentSyntax, childSyntax) => parentSyntax.WithByExpression(childSyntax));
            groupExpression = new CachedExpressionNode<QueryGroupIntoExpressionWithCodeAnalysis, GroupClauseSyntax>(
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
            get { return node.GetParentNode<QueryBodyWithCodeAnalysis>().IntoExpression; }
            set { node.GetParentNode<QueryBodyWithCodeAnalysis>().IntoExpression = value; }
        }

        public GroupClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        SelectOrGroupClauseSyntax IHasSyntax<SelectOrGroupClauseSyntax>.Syntax
        {
            get => Syntax;
            set => Syntax = (GroupClauseSyntax)value;
        }

        INode<SelectOrGroupClauseSyntax> IHasNode<SelectOrGroupClauseSyntax>.Node => node;

        INode<GroupClauseSyntax> IHasNode<GroupClauseSyntax>.Node => node;
    }
}
