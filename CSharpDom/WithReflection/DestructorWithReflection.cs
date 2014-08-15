using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithReflection
{
    public sealed class DestructorWithReflection
    {
        private readonly IDestructorWithReflection destructor;

        public DestructorWithReflection(IDestructorWithReflection destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public ClassDeclarationWithReflection DeclaringType
        {
            get { return new ClassDeclarationWithReflection(destructor.DeclaringType); }
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

        public IDestructorWithReflection AsInterface()
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
