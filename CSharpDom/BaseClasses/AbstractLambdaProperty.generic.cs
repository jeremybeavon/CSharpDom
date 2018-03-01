using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        AbstractGenericVisitableObject,
        ILambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract IReadOnlyCollection<TAttributeGroup> Attributes { get; }

        public abstract TDeclaringType DeclaringType { get; }

        public abstract string Name { get; }

        public abstract TTypeReference PropertyType { get; }

        public abstract TExpression LambdaExpression { get; }
    }
}
