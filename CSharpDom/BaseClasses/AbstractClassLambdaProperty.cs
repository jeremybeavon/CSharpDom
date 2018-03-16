using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        AbstractLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassLambdaProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassLambdaPropertyChildren(this, visitor);
        }
    }
}
