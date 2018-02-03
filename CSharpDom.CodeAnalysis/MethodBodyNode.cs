using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal class MethodBodyNode<TParent, TParentSyntax> :
        CachedChildNode<TParent, TParentSyntax, MethodBodyWithCodeAnalysis, BlockSyntax>
        where TParent : class, IHasNode<TParentSyntax>
        where TParentSyntax : class
    {
        public MethodBodyNode(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, BlockSyntax> getChildSyntax,
            Func<TParentSyntax, BlockSyntax, TParentSyntax> createChildSyntax)
            : base(node, () => new MethodBodyWithCodeAnalysis(), getChildSyntax, createChildSyntax)
        {
        }
    }
}
