using System;
using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.Linq.Expressions;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyField : AbstractField<IExpression>
    {
        private readonly Field field;
        private readonly IExpression expression;

        public ReadOnlyField(Field field)
        {
            this.field = field;
            expression = LinqExpressionBuilder.BuildExpression(field.InitialValue);
        }

        public override IExpression InitialValue
        {
            get { return expression; }
        }

        public override string Name
        {
            get { return field.Name; }
        }
    }
}
