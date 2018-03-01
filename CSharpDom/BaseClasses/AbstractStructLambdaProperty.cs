using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression> :
        AbstractLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>,
        IStructLambdaProperty<TAttributeGroup, TDeclaringType, TTypeReference, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStructType
        where TTypeReference : ITypeReference
        where TExpression : IExpression
    {
        public abstract StructMemberInheritanceModifier InheritanceModifier { get; }

        public abstract StructMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructLambdaProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
