using CSharpDom.Common;
using CSharpDom.BaseClasses.Editable.Expressions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis.Expressions
{
    public sealed class QueryGroupExpressionWithCodeAnalysis :
        EditableQueryGroupExpression<IExpressionWithCodeAnalysis>,
        IHasSyntax<GroupClauseSyntax>,
        IInternalQueryEndExpression
    {
        private readonly QueryEndExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax> node;
        private readonly CachedExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax> byExpression;
        private readonly CachedExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax> groupExpression;
       
        internal QueryGroupExpressionWithCodeAnalysis()
        {
            node = new QueryEndExpressionNode<QueryGroupExpressionWithCodeAnalysis, GroupClauseSyntax>(this);
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
        
        public GroupClauseSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        SelectOrGroupClauseSyntax IHasSyntax<SelectOrGroupClauseSyntax>.Syntax { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        INode<SelectOrGroupClauseSyntax> IHasNode<SelectOrGroupClauseSyntax>.Node => throw new System.NotImplementedException();
    }
}
