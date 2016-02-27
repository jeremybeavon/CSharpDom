using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Mono.Cecil.ConstantExpressions
{
    public sealed class DoubleConstantExpressionWithMonoCecil :
        AbstractDoubleConstantExpression,
        IConstantExpressionWithMonoCecil
    {
        private readonly double constant;

        internal DoubleConstantExpressionWithMonoCecil(double constant)
        {
            this.constant = constant;
        }

        public override double Constant
        {
            get { return constant; }
        }
    }
}
