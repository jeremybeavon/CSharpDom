using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class StatementListWrapper<TParentNode, TParentSyntax> :
        WrappedList<IInternalStatement, IStatementWithCodeAnalysis>,
        IChildCollection<IInternalStatement, StatementSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly InternalStatementListWrapper<TParentNode, TParentSyntax> list;

        public StatementListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<StatementSyntax>> getList,
            Func<TParentSyntax, SyntaxList<StatementSyntax>, TParentSyntax> createList,
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
            : this(new InternalStatementListWrapper<TParentNode, TParentSyntax>(node, getList, createList, getCollection))
        {
        }

        private StatementListWrapper(InternalStatementListWrapper<TParentNode, TParentSyntax> list)
            : base(list, parent => parent, child => child as IInternalStatement)
        {
            this.list = list;
        }

        public StatementSyntax GetChild(IInternalStatement child)
        {
            return list.GetChild(child);
        }

        public void SetChild(IInternalStatement child, StatementSyntax syntax)
        {
            list.SetChild(child, syntax);
        }

        public void ReplaceList(IEnumerable<IStatementWithCodeAnalysis> statement)
        {
            list.ReplaceList(statement.Cast<IInternalStatement>());
        }
    }
}
