using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class StatementNode<TValue, TSyntax> : Node<TValue, TSyntax>
        where TSyntax : StatementSyntax
    {
        public StatementNode(TValue value)
            : base(value)
        {
        }

        public void SetStatementParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {

        }

        public void SetStatementParentNode<TParentNode, TParentSyntax>(
            TParentNode parent,
            Func<TParentSyntax, StatementSyntax> getChildSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createChildSyntax)
            where TParentNode : class, IHasSyntax<TParentSyntax>
        {
            SetParentNode<TParentNode, TParentSyntax>(
                parent,
                parentSyntax => (TSyntax)getChildSyntax(parentSyntax),
                (parentSyntax, childSyntax) => createChildSyntax(parentSyntax, (TSyntax)childSyntax));
        }
    }
}
