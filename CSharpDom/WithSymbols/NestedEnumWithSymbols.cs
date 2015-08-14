using System.Collections.Generic;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedEnumWithSymbols : AbstractSymbolNode<INestedEnumWithSymbols>
    {
        private readonly INestedEnumWithSymbols @enum;

        public NestedEnumWithSymbols(INestedEnumWithSymbols @enum)
            : base(@enum)
        {
            this.@enum = @enum;
        }

        public EnumDeclarationSyntax Declaration
        {
            get { return @enum.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(@enum.DeclaringType); }
        }

        public int EndLine
        {
            get { return @enum.EndLine; }
        }

        public IReadOnlyCollection<NestedEnumMemberWithSymbols> EnumMembers
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedEnumMemberWithSymbols, INestedEnumMemberWithSymbols>(
                    @enum.EnumMembers,
                    enumMember => new NestedEnumMemberWithSymbols(enumMember));
            }
        }

        public string Name
        {
            get { return @enum.Name; }
        }

        public int StartLine
        {
            get { return @enum.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @enum.Symbol; }
        }

        public INestedEnumWithSymbols AsInterface()
        {
            return @enum;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @enum.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
