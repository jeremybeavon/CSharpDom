using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedInterfaceDeclarationWithSymbols : BasicTypeWithSymbols
    {
        private readonly INestedInterfaceDeclarationWithSymbols @interface;

        public NestedInterfaceDeclarationWithSymbols(INestedInterfaceDeclarationWithSymbols @interface)
            : base(@interface)
        {
            this.@interface = @interface;
        }

        public NestedInterfaceWithSymbols CompositeType
        {
            get { return new NestedInterfaceWithSymbols(@interface.CompositeType); }
        }

        public InterfaceDeclarationSyntax Declaration
        {
            get { return @interface.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(@interface.DeclaringType); }
        }

        public int EndLine
        {
            get { return @interface.EndLine; }
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

        public int StartLine
        {
            get { return @interface.StartLine; }
        }

        public INamedTypeSymbol Symbol
        {
            get { return @interface.Symbol; }
        }

        public INestedInterfaceDeclarationWithSymbols AsInterface()
        {
            return @interface;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @interface.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
