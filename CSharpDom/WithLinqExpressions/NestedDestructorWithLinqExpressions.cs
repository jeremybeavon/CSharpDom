using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class NestedDestructorWithLinqExpressions
    {
        private readonly INestedDestructorWithLinqExpressions destructor;

        public NestedDestructorWithLinqExpressions(INestedDestructorWithLinqExpressions destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public NestedClassDeclarationWithLinqExpressions DeclaringType
        {
            get { return new NestedClassDeclarationWithLinqExpressions(destructor.DeclaringType); }
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

        public INestedDestructorWithLinqExpressions AsInterface()
        {
            return destructor;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            destructor.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return destructor.ToString();
        }
    }
}
