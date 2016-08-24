using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class AttributeListWrapper<TParentNode, TParentSyntax> :
        SyntaxListWrapper<TParentNode, TParentSyntax, AttributeGroupWithCodeAnalysis, AttributeListSyntax>
        where TParentNode : class
        where TParentSyntax : class
    {
        public AttributeListWrapper(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<AttributeListSyntax>> getList,
            Func<TParentSyntax, SyntaxList<AttributeListSyntax>, TParentSyntax> createList,
            Func<TParentNode, AttributeGroupWithCodeAnalysis> factory,
            Action<AttributeGroupWithCodeAnalysis, TParentNode> setParent)
            : base(node, getList, createList, factory, setParent)
        {
        }
    }
}
