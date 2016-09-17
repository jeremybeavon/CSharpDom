using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class QueryExpressionNode<TValue, TSyntax> : Node<TValue, TSyntax>, INode<QueryClauseSyntax>
        where TValue : IInternalQueryExpression
        where TSyntax : QueryClauseSyntax
    {
        public QueryExpressionNode(TValue value)
            : base(value)
        {
        }

        QueryClauseSyntax IHasSyntax<QueryClauseSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (TSyntax)value; }
        }
        
        void INode<QueryClauseSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, QueryClauseSyntax> getChildSyntax,
            Func<TParentSyntax, QueryClauseSyntax, TParentSyntax> createChildSyntax)
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        void INode<QueryClauseSyntax>.SetParentNode<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TChildNode, QueryClauseSyntax> childCollection)
        {
            SetParentNode<TParentNode, TParentSyntax, TChildNode>(
                parent,
                child,
                new SimpleChildCollection<TChildNode, QueryClauseSyntax, TSyntax>(childCollection));
        }
    }
}
