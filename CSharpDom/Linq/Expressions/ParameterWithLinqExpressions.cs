using CSharpDom.BaseClasses.Expressions;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;
using CSharpDom.NotSupported;
using CSharpDom.Reflection;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CSharpDom.Linq.Expressions
{
    public sealed class ParameterWithLinqExpressions :
        AbstractIdentifierExpression,
        ILinqExpression<ParameterExpression>,
        IParameter<AttributeGroupNotSupported, ITypeReferenceWithReflection>,
        IAnonymousMethodParameter<ITypeReferenceWithReflection>
    {
        private readonly ITypeReferenceWithReflection parameterType;

        public ParameterWithLinqExpressions(ParameterExpression expression)
        {
            Expression = expression;
            this.parameterType = TypeReferenceWithReflectionFactory.CreateReference(expression.Type);
        }

        public IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public ParameterExpression Expression { get; private set; }

        public ParameterModifier Modifier
        {
            get { return ParameterModifier.None; }
        }

        public override string Name
        {
            get { return Expression.Name; }
        }

        public ITypeReferenceWithReflection ParameterType
        {
            get { return parameterType; }
        }

        Expression ILinqExpression.Expression
        {
            get { return Expression; }
        }

        AnonymousMethodParameterModifier IHasModifier<AnonymousMethodParameterModifier>.Modifier =>
            AnonymousMethodParameterModifier.None;

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitParameter(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitParameterChildren(this, visitor);
        }
    }
}
