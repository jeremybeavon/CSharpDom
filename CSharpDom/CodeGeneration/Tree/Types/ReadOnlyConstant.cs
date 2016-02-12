using System;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyConstant : AbstractConstant<IExpression>
    {
        private readonly Field field;
        private readonly IExpression expression;

        public ReadOnlyConstant(Field field)
        {
            this.field = field;
            expression = LinqExpressionBuilder.BuildExpression(field.InitialValue);
        }

        public override IExpression ConstantValue
        {
            get { return expression; }
        }

        public override string Name
        {
            get { return field.Name; }
        }
    }
}
