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
    public sealed class ConstructorWithReflection
    {
        private readonly IConstructorWithReflection constructor;

        public ConstructorWithReflection(IConstructorWithReflection constructor)
        {
            this.constructor = constructor;
        }

        public ConstructorDeclarationSyntax Declaration
        {
            get { return constructor.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(constructor.DeclaringType); }
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

        public IConstructorWithReflection AsInterface()
        {
            return constructor;
        }

        public void Accept(ReflectionVisitor visitor)
        {
            constructor.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return constructor.ToString();
        }
    }
}
