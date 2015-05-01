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
    public sealed class ConversionOperatorWithLinqExpressions
    {
        private readonly IConversionOperatorWithLinqExpressions conversionOperator;

        public ConversionOperatorWithLinqExpressions(IConversionOperatorWithLinqExpressions conversionOperator)
        {
            this.conversionOperator = conversionOperator;
        }

        public ConversionOperatorDeclarationSyntax Declaration
        {
            get { return conversionOperator.Declaration; }
        }

        public TypeWithLinqExpressions DeclaringType
        {
            get { return TypeWithLinqExpressions.GetType(conversionOperator.DeclaringType); }
        }

        public int EndLine
        {
            get { return conversionOperator.EndLine; }
        }

        public int StartLine
        {
            get { return conversionOperator.StartLine; }
        }

        public IMethodSymbol Symbol
        {
            get { return conversionOperator.Symbol; }
        }

        public IConversionOperatorWithLinqExpressions AsInterface()
        {
            return conversionOperator;
        }
        
        public void Accept(LinqExpressionsVisitor visitor)
        {
            conversionOperator.Accept(new LinqExpressionsVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return conversionOperator.ToString();
        }
    }
}
