using CSharpDom.WithSymbols.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithSymbols
{
    public sealed class DestructorWithSymbols : AbstractSymbolNode<IDestructorWithSymbols>
    {
        private readonly IDestructorWithSymbols destructor;

        public DestructorWithSymbols(IDestructorWithSymbols destructor)
            : base(destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public ClassDeclarationWithSymbols DeclaringType
        {
            get { return new ClassDeclarationWithSymbols(destructor.DeclaringType); }
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
