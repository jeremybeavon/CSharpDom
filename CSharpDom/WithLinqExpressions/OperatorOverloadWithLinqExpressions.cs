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
    public sealed class OperatorOverloadWithLinqExpressions
    {
        private readonly IOperatorOverloadWithLinqExpressions operatorOverload;

        public OperatorOverloadWithLinqExpressions(IOperatorOverloadWithLinqExpressions operatorOverload)
        {
            this.operatorOverload = operatorOverload;
        }

        public OperatorDeclarationSyntax Declaration
        {
            get { return operatorOverload.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(operatorOverload.DeclaringType); }
        }

        public int EndLine
        {
            get { return operatorOverload.EndLine; }
        }

        public int StartLine
        {
            get { return operatorOverload.StartLine; }
        }

        public IMethodSymbol Symbol
        {
            get { return operatorOverload.Symbol; }
        }

        public void Accept(LinqExpressionsVisitor visitor)
        {
            operatorOverload.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return operatorOverload.ToString();
        }
    }
}
