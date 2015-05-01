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
    public sealed class DestructorWithLinqExpressions
    {
        private readonly IDestructorWithLinqExpressions destructor;

        public DestructorWithLinqExpressions(IDestructorWithLinqExpressions destructor)
        {
            this.destructor = destructor;
        }

        public DestructorDeclarationSyntax Declaration
        {
            get { return destructor.Declaration; }
        }

        public ClassDeclarationWithLinqExpressions DeclaringType
        {
            get { return new ClassDeclarationWithLinqExpressions(destructor.DeclaringType); }
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

        public IDestructorWithLinqExpressions AsInterface()
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
