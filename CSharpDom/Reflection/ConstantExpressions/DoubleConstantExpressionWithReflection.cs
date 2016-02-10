using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Reflection.ConstantExpressions
{
    public sealed class DoubleConstantExpressionWithReflection :
        AbstractDoubleConstantExpression,
        IConstantExpressionWithReflection
    {
        private readonly double constant;

        internal DoubleConstantExpressionWithReflection(double constant)
        {
            this.constant = constant;
        }

        public override double Constant
        {
            get { return constant; }
        }
    }
}
