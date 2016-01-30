using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Linq.Expressions
{
    public sealed class DefaultExpressionWithLinqExpressions :
        AbstractDefaultExpression<ITypeReferenceWithReflection>,
        ILinqExpression<DefaultExpression>
    {
        private readonly ITypeReferenceWithReflection type;

        public DefaultExpressionWithLinqExpressions(DefaultExpression expression)
        {
            Expression = expression;
            type = TypeReferenceWithReflectionFactory.CreateReference(expression.Type);
        }

        public DefaultExpression Expression { get; private set; }

        public override ITypeReferenceWithReflection Type
        {
            get { return type; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
