using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Mono.Cecil.ConstantExpressions
{
    public sealed class IntegerConstantExpressionWithMonoCecil :
        AbstractIntegerConstantExpression,
        IConstantExpressionWithMonoCecil
    {
        private readonly int constant;

        internal IntegerConstantExpressionWithMonoCecil(int constant)
        {
            this.constant = constant;
        }

        public override int Constant
        {
            get { return constant; }
        }
    }
}
