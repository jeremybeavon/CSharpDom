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
    public sealed class ConversionOperatorWithReflection
    {
        private readonly IConversionOperatorWithReflection conversionOperator;

        public ConversionOperatorWithReflection(IConversionOperatorWithReflection conversionOperator)
        {
            this.conversionOperator = conversionOperator;
        }

        public ConversionOperatorDeclarationSyntax Declaration
        {
            get { return conversionOperator.Declaration; }
        }

        public TypeWithReflection DeclaringType
        {
            get { return TypeWithReflection.GetType(conversionOperator.DeclaringType); }
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

        public IConversionOperatorWithReflection AsInterface()
        {
            return conversionOperator;
        }
        
        public void Accept(ReflectionVisitor visitor)
        {
            conversionOperator.Accept(new ReflectionVisitorMapping(visitor));
        }

        public override string ToString()
        {
            return conversionOperator.ToString();
        }
    }
}
