using System.Collections.Generic;
using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedInterfaceWithSymbols : BasicTypeWithSymbols
    {
        private readonly INestedInterfaceWithSymbols @interface;

        public NestedInterfaceWithSymbols(INestedInterfaceWithSymbols @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public IReadOnlyCollection<NestedInterfaceDeclarationWithSymbols> Declarations
        {
            get
            {
                return new ReadOnlyNodeCollection<NestedInterfaceDeclarationWithSymbols, INestedInterfaceDeclarationWithSymbols>(
                    @interface.Declarations,
                    declaration => new NestedInterfaceDeclarationWithSymbols(declaration));
            }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(@interface.DeclaringType); }
        }

        public int GenericParameterCount
        {
            get { return @interface.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @interface.IsGeneric; }
        }

        public string Name
        {
            get { return @interface.Name; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @interface.Symbol; }
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @interface.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
