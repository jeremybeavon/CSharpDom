using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Reflection.ConstantExpressions
{
    public sealed class StringConstantExpressionWithReflection :
        AbstractStringConstantExpression,
        IConstantExpressionWithReflection
    {
        private readonly string constant;

        internal StringConstantExpressionWithReflection(string constant)
        {
            this.constant = constant;
        }

        public override string Constant
        {
            get { return constant; }
        }

        public override bool HasAtSymbol
        {
            get { return false; }
        }
    }
}
