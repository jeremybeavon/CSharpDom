using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class MethodBodyNode<TParentNode, TParentSyntax> :
        CachedChildNode<TParentNode, TParentSyntax, MethodBodyWithCodeAnalysis, BlockSyntax>
        where TParentNode : class, IHasSyntax<TParentSyntax>
        where TParentSyntax : class
    {
        public MethodBodyNode(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, BlockSyntax> getChildSyntax,
            Func<TParentSyntax, BlockSyntax, TParentSyntax> createChildSyntax)
            : base(node, () => new MethodBodyWithCodeAnalysis(), getChildSyntax, createChildSyntax)
        {
        }
    }
}
