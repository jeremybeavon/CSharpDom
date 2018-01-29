using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    internal class StatementListWrapper<TParentNode, TParentSyntax> :
        WrappedList<IInternalStatement, IStatementWithCodeAnalysis>,
        IChildCollection<TParentSyntax, IInternalStatement, StatementSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly SyntaxNodeList<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax> list;

        public StatementListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<StatementSyntax>> getList,
            Func<TParentSyntax, SyntaxList<StatementSyntax>, TParentSyntax> createList)
            : this(ListFactory.CreateList(node, getList, createList, StatementSyntaxExtensions.ToInternalStatement))
        {
        }

        private StatementListWrapper(SyntaxNodeList<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax> list)
            : base(list, parent => parent, child => child as IInternalStatement)
        {
            this.list = list;
        }

        public StatementSyntax GetChild(IInternalStatement child)
        {
            return list.GetChild(child);
        }

        public TParentSyntax SetChild(IInternalStatement child, StatementSyntax syntax)
        {
            return list.SetChild(child, syntax);
        }

        public void ReplaceList(IEnumerable<IStatementWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Cast<IInternalStatement>());
        }
    }
}
