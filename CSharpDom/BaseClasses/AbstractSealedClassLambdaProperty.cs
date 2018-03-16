using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        AbstractLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        ISealedClassLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassLambdaProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitSealedClassLambdaPropertyChildren(this, visitor);
        }
    }
}
