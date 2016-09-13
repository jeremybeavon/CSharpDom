using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal class CachedStatementNode<TParentNode, TParentSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        private readonly CachedChildNode<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax> childNode;

        public CachedStatementNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, StatementSyntax> getSyntax,
            Func<TParentSyntax, StatementSyntax, TParentSyntax> createSyntax)
        {
            childNode = new CachedChildNode<TParentNode, TParentSyntax, IInternalStatement, StatementSyntax>(
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
