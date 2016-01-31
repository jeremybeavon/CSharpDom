using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class NewExpressionWithLinqExpressions :
        AbstractNewExpression<ITypeReferenceWithReflection, ILinqExpression>,
        ILinqExpression<NewExpression>
    {
        private readonly IReadOnlyList<ILinqExpression> parameters;
        private readonly ITypeReferenceWithReflection type;

        public NewExpressionWithLinqExpressions(NewExpression expression)
        {
            Expression = expression;
            parameters = LinqExpressionBuilder.BuildExpressions(expression.Arguments);
            type = TypeReferenceWithReflectionFactory.CreateReference(expression.Constructor.DeclaringType);
        }

        public NewExpression Expression { get; private set; }

        public override IReadOnlyList<ILinqExpression> Parameters
        {
            get { return parameters; }
        }

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
