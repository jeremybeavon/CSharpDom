using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class PropertyWithSymbols : AbstractSymbolNode<IPropertyWithSymbols>
    {
        private readonly IPropertyWithSymbols property;

        public PropertyWithSymbols(IPropertyWithSymbols property)
            : base(property)
        {
            this.property = property;
        }
        
        public BasicTypeWithSymbols DeclaringType
        {
            get { return BasicTypeWithSymbols.GetBasicType(property.DeclaringType); }
        }
        
        public bool HasSet
        {
            get { return property.HasSet; }
        }

        public string Name
        {
            get { return property.Name; }
        }
        
        public IPropertySymbol Symbol
        {
            get { return property.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            property.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
