using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Reflection.ConstantExpressions
{
    public sealed class IntegerConstantExpressionWithReflection :
        AbstractIntegerConstantExpression,
        IConstantExpressionWithReflection
    {
        private readonly int constant;

        internal IntegerConstantExpressionWithReflection(int constant)
        {
            this.constant = constant;
        }

        public override int Constant
        {
            get { return constant; }
        }
    }
}
