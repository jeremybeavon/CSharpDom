using CSharpDom.BaseClasses.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ObjectInitializerExpressionWithLinqExpressions :
        AbstractObjectInitializerExpression<
            ICreateObjectLinqExpression,
            ILinqExpression,
            ObjectInitializersWithLinqExpressions>,
        ILinqExpression<MemberInitExpression>
    {
        private readonly ICreateObjectLinqExpression createObjectExpression;
        private readonly ObjectInitializersWithLinqExpressions initializer;        

        public ObjectInitializerExpressionWithLinqExpressions(MemberInitExpression expression)
        {
            Expression = expression;
            createObjectExpression = (ICreateObjectLinqExpression)LinqExpressionBuilder.BuildExpression(expression.NewExpression);
            initializer = new ObjectInitializersWithLinqExpressions(expression.Bindings);
        }

        public override ICreateObjectLinqExpression CreateObjectExpression
        {
            get { return createObjectExpression; }
        }

        public override IReadOnlyList<IReadOnlyList<ILinqExpression>> Elements
        {
            get { return initializer.Elements; }
        }

        public MemberInitExpression Expression { get; private set; }

        public override IReadOnlyDictionary<string, ObjectInitializersWithLinqExpressions> Initializers
        {
            get { return initializer.Initializers; }
        }

        public override IReadOnlyDictionary<string, ILinqExpression> Members
        {
            get { return initializer.Members; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
