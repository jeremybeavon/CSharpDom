using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class EnumMemberWithSymbols : AbstractSymbolNode<IEnumMemberWithSymbols>
    {
        private readonly IEnumMemberWithSymbols enumMember;

        public EnumMemberWithSymbols(IEnumMemberWithSymbols enumMember)
            : base(enumMember)
        {
            this.enumMember = enumMember;
        }

        public EnumMemberDeclarationSyntax Declaration
        {
            get { return enumMember.Declaration; }
        }

        public EnumWithSymbols DeclaringType
        {
            get { return new EnumWithSymbols(enumMember.DeclaringType); }
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

        public override void Accept(SymbolsVisitor visitor)
        {
            enumMember.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
