using CSharpDom.Common.Expressions;
using CSharpDom.Serialization.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Serialization.Factories.Expressions
{
    public sealed class ExpressionFactory : AbstractExpressionFactory<IExpression, Expression>
    {
        public ExpressionFactory(IExpression expression)
            : base(expression)
        {
        }
    }
}
