using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedStructDeclarationWithSymbols : TypeWithSymbols
    {
        private readonly INestedStructDeclarationWithSymbols @struct;

        public NestedStructDeclarationWithSymbols(INestedStructDeclarationWithSymbols @struct)
            : base(@struct)
        {
            this.@struct = @struct;
        }

        public NestedStructWithSymbols CompositeType
        {
            get { return new NestedStructWithSymbols(@struct.CompositeType); }
        }

        public StructDeclarationSyntax Declaration
        {
            get { return @struct.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return GetType(@struct.DeclaringType); }
        }

        public int EndLine
        {
            get { return @struct.EndLine; }
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

        public int StartLine
        {
            get { return @struct.StartLine; }
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
