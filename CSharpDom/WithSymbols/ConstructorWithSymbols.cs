using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class ConstructorWithSymbols : AbstractSymbolNode<IConstructorWithSymbols>
    {
        private readonly IConstructorWithSymbols constructor;

        public ConstructorWithSymbols(IConstructorWithSymbols constructor)
            : base(constructor)
        {
            this.constructor = constructor;
        }

        public ConstructorDeclarationSyntax Declaration
        {
            get { return constructor.Declaration; }
        }

        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(constructor.DeclaringType); }
        }

        public int EndLine
        {
            get { return constructor.EndLine; }
        }

        public int StartLine
        {
            get { return constructor.StartLine; }
        }

        public IMethodSymbol Symbol
        {
            get { return constructor.Symbol; }
        }

        public IConstructorWithSymbols AsInterface()
        {
            return constructor;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            constructor.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
