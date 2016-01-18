using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class EnumMemberWithSymbols : AbstractSymbolNode<IEnumMemberWithSymbols>
    {
        private readonly IEnumMemberWithSymbols enumMember;

        public EnumMemberWithSymbols(IEnumMemberWithSymbols enumMember)
            : base(enumMember)
        {
            this.enumMember = enumMember;
        }
        
        public EnumWithSymbols DeclaringType
        {
            get { return new EnumWithSymbols(enumMember.DeclaringType); }
        }
        
        public string Name
        {
            get { return enumMember.Name; }
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
