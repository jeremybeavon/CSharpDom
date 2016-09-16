using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class StatementNode<TValue, TSyntax> : Node<TValue, TSyntax>, INode<StatementSyntax>
        where TValue : IInternalStatement
        where TSyntax : StatementSyntax
    {
        public StatementNode(TValue value)
            : base(value)
        {
        }

        StatementSyntax IHasSyntax<StatementSyntax>.Syntax
        {
            get { return Syntax; }
            set { Syntax = (TSyntax)value; }
        }
        
        void INode<StatementSyntax>.SetParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, StatementSyntax> getChildSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createChildSyntax)
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, childSyntax));
        }

        void INode<StatementSyntax>.SetParentNode<TParentNode, TParentSyntax, TChildNode>(
            TParentNode parent,
            TChildNode child,
            IChildCollection<TChildNode, StatementSyntax> childCollection)
        {
            SetParentNode<TParentNode, TParentSyntax, TChildNode>(
                parent,
                child,
                new SimpleChildCollection<TChildNode, StatementSyntax, TSyntax>(childCollection));
        }
    }
}
