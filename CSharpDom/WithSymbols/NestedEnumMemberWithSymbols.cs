using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedEnumMemberWithSymbols : AbstractSymbolNode<INestedEnumMemberWithSymbols>
    {
        private readonly INestedEnumMemberWithSymbols enumMember;

        public NestedEnumMemberWithSymbols(INestedEnumMemberWithSymbols enumMember)
            : base(enumMember)
        {
            this.enumMember = enumMember;
        }

        public EnumMemberDeclarationSyntax Declaration
        {
            get { return enumMember.Declaration; }
        }

        public NestedEnumWithSymbols DeclaringType
        {
            get { return new NestedEnumWithSymbols(enumMember.DeclaringType); }
        }

        public int EndLine
        {
            get { return enumMember.EndLine; }
        }

        public string Name
        {
            get { return enumMember.Name; }
        }

        public int StartLine
        {
            get { return enumMember.StartLine; }
        }

        public IFieldSymbol Symbol
        {
            get { return enumMember.Symbol; }
        }

        public INestedEnumMemberWithSymbols AsInterface()
        {
            return enumMember;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            enumMember.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
