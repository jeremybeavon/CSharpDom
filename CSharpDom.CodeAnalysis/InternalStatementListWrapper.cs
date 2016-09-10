using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    internal class InternalStatementListWrapper<TParentNode, TParentSyntax>
        : SyntaxListWrapper<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        public InternalStatementListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<StatementSyntax>> getList,
            Func<TParentSyntax, SyntaxList<StatementSyntax>, TParentSyntax> createList,
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
            : this(
                  node,
                  getList,
                  createList,
                  new InternalStatementListWrapperBuilder<TParentNode, TParentSyntax>(getCollection))
        {
        }

        private InternalStatementListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<StatementSyntax>> getList,
            Func<TParentSyntax, SyntaxList<StatementSyntax>, TParentSyntax> createList,
            InternalStatementListWrapperBuilder<TParentNode, TParentSyntax> builder)
            : base(node, getList, createList, builder.CreateStatement, builder.SetParent)
        {
        }
    }
}
