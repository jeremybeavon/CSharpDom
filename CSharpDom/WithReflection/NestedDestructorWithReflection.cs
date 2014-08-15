using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class NestedDestructorWithReflection
    {
        private readonly INestedDestructorWithReflection destructor;

        public NestedDestructorWithReflection(INestedDestructorWithReflection destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public NestedClassDeclarationWithReflection DeclaringType
        {
            get { return new NestedClassDeclarationWithReflection(destructor.DeclaringType); }
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

        public INestedDestructorWithReflection AsInterface()
        {
            return destructor;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            destructor.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return destructor.ToString();
        }
    }
}
