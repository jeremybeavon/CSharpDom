using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class FieldWithSymbols : AbstractSymbolNode<IFieldWithSymbols>
    {
        private readonly IFieldWithSymbols field;

        public FieldWithSymbols(IFieldWithSymbols field)
            : base(field)
        {
            this.field = field;
        }
        
        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(field.DeclaringType); }
        }
        
        public string Name
        {
            get { return field.Name; }
        }
        
        public IFieldSymbol Symbol
        {
            get { return field.Symbol; }
        }

        public IFieldWithSymbols AsInterface()
        {
            return field;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            field.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
