using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedStructWithSymbols : TypeWithSymbols
    {
        private readonly INestedStructWithSymbols @struct;

        public NestedStructWithSymbols(INestedStructWithSymbols @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public IReadOnlyCollection<NestedStructDeclarationWithSymbols> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedStructDeclarationWithSymbols, INestedStructDeclarationWithSymbols>(
                    @struct.Declarations,
                    declaration => new NestedStructDeclarationWithSymbols(declaration));
            }
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
