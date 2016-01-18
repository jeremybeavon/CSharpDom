using CSharpDom.CodeAnalysis.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis.WithSymbols
{
    public sealed class DestructorWithSymbols : AbstractSymbolNode<IDestructorWithSymbols>
    {
        private readonly IDestructorWithSymbols destructor;

        public DestructorWithSymbols(IDestructorWithSymbols destructor)
            : base(destructor)
        {
            this.destructor = destructor;
        }
        
        public ClassWithSymbols DeclaringType
        {
            get { return new ClassWithSymbols(destructor.DeclaringType); }
        }
        
        public IMethodSymbol Symbol
        {
            get { return destructor.Symbol; }
        }

        public IDestructorWithSymbols AsInterface()
        {
            return destructor;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            destructor.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
