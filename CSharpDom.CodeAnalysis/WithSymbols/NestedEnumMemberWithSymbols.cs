using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class NestedEnumMemberWithSymbols : AbstractSymbolNode<INestedEnumMemberWithSymbols>
    {
        private readonly INestedEnumMemberWithSymbols enumMember;

        public NestedEnumMemberWithSymbols(INestedEnumMemberWithSymbols enumMember)
            : base(enumMember)
        {
            this.enumMember = enumMember;
        }
        
        public NestedEnumWithSymbols DeclaringType
        {
            get { return new NestedEnumWithSymbols(enumMember.DeclaringType); }
        }
        
        public string Name
        {
            get { return enumMember.Name; }
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
