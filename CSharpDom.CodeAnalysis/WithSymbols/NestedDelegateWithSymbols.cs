using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class NestedDelegateWithSymbols : AbstractSymbolNode<INestedDelegateWithSymbols>
    {
        private readonly INestedDelegateWithSymbols @delegate;

        public NestedDelegateWithSymbols(INestedDelegateWithSymbols @delegate)
            : base(@delegate)
        {
            this.@delegate = @delegate;
        }
        
        public TypeWithSymbols DeclaringType
        {
            get { return TypeWithSymbols.GetType(@delegate.DeclaringType); }
        }
        
        public int GenericParameterCount
        {
            get { return @delegate.GenericParameterCount; }
        }

        public bool IsGeneric
        {
            get { return @delegate.IsGeneric; }
        }

        public string Name
        {
            get { return @delegate.Name; }
        }
        
        public INamedTypeSymbol Symbol
        {
            get { return @delegate.Symbol; }
        }

        public INestedDelegateWithSymbols AsInterface()
        {
            return @delegate;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            @delegate.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
