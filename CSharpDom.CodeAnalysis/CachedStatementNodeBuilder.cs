using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class CachedStatementNodeBuilder<TParentNode, TParentSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly Func<TParentSyntax, StatementSyntax> getSyntax;
        private readonly Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax;

        public CachedStatementNodeBuilder(
            Func<TParentSyntax, StatementSyntax> getSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax)
        {
            this.getSyntax = getSyntax;
            this.createSyntax = createSyntax;
        }

        public IInternalStatement GetValue(TParentNode parent, StatementSyntax syntax)
        {
            IInternalStatement statement = syntax.ToInternalStatement();
            SetParent(statement, parent);
            return statement;
        }

        public void SetParent(IInternalStatement child, TParentNode parent)
        {
            child.SetParentNode(parent, getSyntax, createSyntax);
        }
    }
}
