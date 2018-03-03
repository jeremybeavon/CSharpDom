using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal class StructPropertyListWrapper<TStruct, TChild> :
        StructTypeMemberListWrapper<TStruct, TChild, PropertyDeclarationSyntax>
        where TStruct : class, IHasNode<StructDeclarationSyntax>
        where TChild : class, IHasNode<PropertyDeclarationSyntax>
    {
        public StructPropertyListWrapper(
            Node<TStruct, StructDeclarationSyntax> node,
            Func<TChild> factory,
            Func<PropertyDeclarationSyntax, bool> filter = null)
            : base(node, factory, filter)
        {
        }
    }
}
