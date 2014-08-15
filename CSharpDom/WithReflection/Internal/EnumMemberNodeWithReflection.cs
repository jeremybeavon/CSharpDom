using System;
using CSharpDom.Common;
using CSharpDom.WithSymbols;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection.Internal
{
    internal class EnumMemberNodeWithReflection : EnumMemberNodeWithSymbols, IEnumMemberWithReflection,
        INestedEnumMemberWithReflection
    {
        public EnumMemberNodeWithReflection(
            EnumMemberDeclarationSyntax declaration,
            EnumNode container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IEnumMemberWithSymbols Symbols
        {
            get { return this; }
        }

        INestedEnumWithReflection IHasDeclaringType<INestedEnumWithReflection>.DeclaringType
        {
            get { return (INestedEnumWithReflection)DeclaringType; }
        }

        IEnumWithReflection IHasDeclaringType<IEnumWithReflection>.DeclaringType
        {
            get { return (IEnumWithReflection)DeclaringType; }
        }

        INestedEnumMemberWithSymbols IHasSymbols<INestedEnumMemberWithSymbols>.Symbols
        {
            get { return this; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            Accept(new ReflectionNodeVisitor(visitor));
        }
    }
}
