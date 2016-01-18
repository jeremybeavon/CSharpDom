using System.Collections.Generic;
using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class NestedStructWithSymbols : TypeWithSymbols
    {
        private readonly INestedStructWithSymbols @struct;

        public NestedStructWithSymbols(INestedStructWithSymbols @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }
        
        public TypeWithSymbols DeclaringType
        {
            get { return GetType(@struct.DeclaringType); }
        }

        public int GenericParameterCount
        {
            get { return @struct.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @struct.IsGeneric; }
        }

        public string Name
        {
            get { return @struct.Name; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @struct.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @struct.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
