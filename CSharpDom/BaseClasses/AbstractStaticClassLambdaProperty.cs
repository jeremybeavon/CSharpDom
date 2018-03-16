using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        AbstractLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IStaticClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract StaticClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassLambdaProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassLambdaPropertyChildren(this, visitor);
        }
    }
}
