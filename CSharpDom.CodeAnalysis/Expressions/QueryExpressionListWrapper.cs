using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class QueryExpressionListWrapper<TParent, TParentSyntax> :
        WrappedList<IInternalQueryExpression, IQueryExpressionWithCodeAnalysis>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly SyntaxNodeList<TParent, TParentSyntax, IInternalQueryExpression, QueryClauseSyntax> list;

        public QueryExpressionListWrapper(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<QueryClauseSyntax>> getList,
            Func<TParentSyntax, SyntaxList<QueryClauseSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateNodeList(node, getList, createList, QueryClauseSyntaxExtensions.ToInternalQueryExpression))
        {
        }

        private QueryExpressionListWrapper(
            SyntaxNodeList<TParent, TParentSyntax, IInternalQueryExpression, QueryClauseSyntax> list)
            : base(list, parent => parent, child => child as IInternalQueryExpression)
        {
            this.list = list;
        }
        
        public void ReplaceList(IEnumerable<IQueryExpressionWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Cast<IInternalQueryExpression>());
        }
    }
}
