using System;
using CSharpDom.BaseClasses.Expressions;

namespace CSharpDom.Mono.Cecil.ConstantExpressions
{
    public sealed class StringConstantExpressionWithMonoCecil :
        AbstractStringConstantExpression,
        IConstantExpressionWithMonoCecil
    {
        private readonly string constant;

        internal StringConstantExpressionWithMonoCecil(string constant)
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
