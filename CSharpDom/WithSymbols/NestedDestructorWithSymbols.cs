using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class NestedDestructorWithSymbols : AbstractSymbolNode<INestedDestructorWithSymbols>
    {
        private readonly INestedDestructorWithSymbols destructor;

        public NestedDestructorWithSymbols(INestedDestructorWithSymbols destructor)
            : base(destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public NestedClassDeclarationWithSymbols DeclaringType
        {
            get { return new NestedClassDeclarationWithSymbols(destructor.DeclaringType); }
        }

        public int EndLine
        {
            get { return destructor.EndLine; }
        }

        public int StartLine
        {
            get { return destructor.StartLine; }
        }

        public IMethodSymbol Symbol
        {
            get { return destructor.Symbol; }
        }

        public INestedDestructorWithSymbols AsInterface()
        {
            return destructor;
        }

        public override void Accept(SymbolsVisitor visitor)
        {
            destructor.Accept(new SymbolsVisitorMapping(visitor));
        }
    }
}
