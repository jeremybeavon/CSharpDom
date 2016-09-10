using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class InternalStatementListWrapperBuilder<TParentNode, TParentSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
    {
        private readonly Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection;

        public InternalStatementListWrapperBuilder(
            Func<TParentNode, IChildCollection<IInternalStatement, StatementSyntax>> getCollection)
        {
            this.getCollection = getCollection;
        }

        public IInternalStatement CreateStatement(TParentNode parent, StatementSyntax childSyntax)
        {
            IInternalStatement statement = childSyntax.ToInternalStatement();
            SetParent(statement, parent);
            return statement;
        }

        public void SetParent(IInternalStatement child, TParentNode parent)
        {
            child.SetParentNode<TParentNode, TParentSyntax>(parent, getCollection);
        }
    }
}
