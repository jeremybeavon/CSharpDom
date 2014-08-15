using System;
using CSharpDom.Common;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSyntax.Internal
{
    internal class EnumMemberNodeWithSyntax : EnumMemberNode, IEnumMemberSyntax, INestedEnumMemberSyntax
    {
        public EnumMemberNodeWithSyntax(EnumMemberDeclarationSyntax declaration, EnumNode container)
            : base(declaration, container)
        {
        }

        INestedEnumSyntax IHasDeclaringType<INestedEnumSyntax>.DeclaringType
        {
            get { return (INestedEnumSyntax)DeclaringType; }
        }

        IEnumSyntax IHasDeclaringType<IEnumSyntax>.DeclaringType
        {
            get { return (IEnumSyntax)DeclaringType; }
        }

        public void Accept(ISyntaxVisitor visitor)
        {
            Accept(new SyntaxNodeVisitor(visitor));
        }

        public override AbstractSyntaxNode CreateNode()
        {
            return IsNested ? (AbstractSyntaxNode)new NestedEnumMemberWithSyntax(this) : new EnumMemberWithSyntax(this);
        }
    }
}
