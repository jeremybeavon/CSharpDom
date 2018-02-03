using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedStatementNode<TParent, TParentSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParent, TParentSyntax, IInternalStatement, StatementSyntax> childNode;

        public CachedStatementNode(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, StatementSyntax> getSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax)
        {
            childNode = new CachedChildNode<TParent, TParentSyntax, IInternalStatement, StatementSyntax>(
                node,
                StatementSyntaxExtensions.ToInternalStatement,
                getSyntax,
                createSyntax);
        }
        
        public IStatementWithCodeAnalysis Value
        {
            get { return childNode.Value; }
            set { childNode.Value = (IInternalStatement)value; }
        }
    }
}
