using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis.Expressions
{
    internal class QueryEndExpressionNode<TValue, TSyntax> : Node<TValue, TSyntax>, INode<SelectOrGroupClauseSyntax>
        where TValue : IInternalQueryEndExpression
        where TSyntax : SelectOrGroupClauseSyntax
    {
        public QueryEndExpressionNode(TValue value)
            : base(value)
        {
        }

        SelectOrGroupClauseSyntax IHasSyntax<SelectOrGroupClauseSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (TSyntax)value; }
        }
        
        void INode<SelectOrGroupClauseSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, SelectOrGroupClauseSyntax> getChildSyntax,
            Func<TParentSyntax, SelectOrGroupClauseSyntax, TParentSyntax> createChildSyntax)
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        void INode<SelectOrGroupClauseSyntax>.SetParentNode<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TParentSyntax, TChildNode, SelectOrGroupClauseSyntax> childCollection)
        {
            SetParentNode(
                parent,
                child,
                new SimpleChildCollection<TParentSyntax, TChildNode, SelectOrGroupClauseSyntax, TSyntax>(childCollection));
        }
    }
}
