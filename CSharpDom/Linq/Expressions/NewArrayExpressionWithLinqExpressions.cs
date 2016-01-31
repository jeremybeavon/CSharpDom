using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Reflection;
using CSharpDom.Reflection.Internal;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace CSharpDom.Linq.Expressions
{
    public sealed class NewArrayExpressionWithLinqExpressions :
        AbstractNewArrayExpression<ITypeReferenceWithReflection, ILinqExpression>,
        ILinqExpression<NewArrayExpression>
    {
        private readonly List<int> dimensions;
        private readonly ITypeReferenceWithReflection elementType;
        private readonly IReadOnlyList<ILinqExpression> initialSizeExpressions;

        public NewArrayExpressionWithLinqExpressions(NewArrayExpression expression)
        {
            Expression = expression;
            for (Type arrayType = expression.Type; arrayType.IsArray; arrayType = arrayType.GetElementType())
            {
                dimensions.Add(arrayType.GetArrayRank());
            }

            elementType = TypeReferenceWithReflectionFactory.CreateReference(expression.Type.GetElementType());
            initialSizeExpressions = LinqExpressionBuilder.BuildExpressions(expression.Expressions);
        }

        public override IReadOnlyList<int> Dimensions
        {
            get { return dimensions; }
        }

        public override ITypeReferenceWithReflection ElementType
        {
            get { return elementType; }
        }

        public NewArrayExpression Expression { get; private set; }

        public override IReadOnlyList<ILinqExpression> InitialSizeExpressions
        {
            get { return initialSizeExpressions; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }
    }
}
