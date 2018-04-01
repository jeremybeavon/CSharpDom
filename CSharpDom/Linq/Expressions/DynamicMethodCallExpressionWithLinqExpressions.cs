using CSharpDom.BaseClasses.Expressions;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using CSharpDom.Reflection;

namespace CSharpDom.Linq.Expressions
{
    public sealed class DynamicMethodCallExpressionWithLinqExpressions :
        AbstractMethodCallExpression<ILinqExpression, ITypeReferenceWithReflection, ILinqExpression>,
        ILinqExpression<DynamicExpression>
    {
        //private readonly ILinqExpression expression;
        private readonly IReadOnlyList<ILinqExpression> parameterExpressions;

        public DynamicMethodCallExpressionWithLinqExpressions(DynamicExpression expression)
        {
            LinqExpression = expression;
            //this.expression = LinqExpressionBuilder.BuildExpression(expression.);
            parameterExpressions = LinqExpressionBuilder.BuildExpressions(expression.Arguments);
            throw new NotImplementedException();
        }

        public DynamicExpression LinqExpression { get; private set; }

        public string Name { get => throw new NotSupportedException(); }

        public override ILinqExpression Expression
        {
            get { return null; }
        }

        public override IReadOnlyList<ILinqExpression> Parameters
        {
            get { return parameterExpressions; }
        }

        public override IReadOnlyList<ITypeReferenceWithReflection> GenericParameters => throw new NotImplementedException();

        Expression ILinqExpression.Expression
        {
            get { return LinqExpression; }
        }

        DynamicExpression ILinqExpression<DynamicExpression>.Expression
        {
            get { return LinqExpression; }
        }
    }
}
