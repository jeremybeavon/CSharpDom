using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class QueryExpressionListWrapper<TParentNode, TParentSyntax> :
        WrappedList<IInternalQueryExpression, IQueryExpressionWithCodeAnalysis>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly SyntaxNodeList<TParentNode, TParentSyntax, IInternalQueryExpression, QueryClauseSyntax> list;

        public QueryExpressionListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<QueryClauseSyntax>> getList,
            Func<TParentSyntax, SyntaxList<QueryClauseSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateList(node, getList, createList, QueryClauseSyntaxExtensions.ToInternalQueryExpression))
        {
        }

        private QueryExpressionListWrapper(
            SyntaxNodeList<TParentNode, TParentSyntax, IInternalQueryExpression, QueryClauseSyntax> list)
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
