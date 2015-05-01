using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.WithLinqExpressions.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions
{
    public sealed class ConstructorWithLinqExpressions
    {
        private readonly IConstructorWithLinqExpressions constructor;

        public ConstructorWithLinqExpressions(IConstructorWithLinqExpressions constructor)
        {
            this.constructor = constructor;
        }

        public ConstructorDeclarationSyntax Declaration
        {
            get { return constructor.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(constructor.DeclaringType); }
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

        public IConstructorWithLinqExpressions AsInterface()
        {
            return constructor;
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            constructor.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return constructor.ToString();
        }
    }
}
