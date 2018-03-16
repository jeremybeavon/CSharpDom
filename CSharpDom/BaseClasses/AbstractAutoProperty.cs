using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        AbstractProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>,
        IAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IBasicType
        where TTypeReference : ITypeReference
        where TAccessor : IAutoPropertyAccessor
        where TExpression : IExpression
    {
        public abstract TExpression InitialValue { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitAutoProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitAutoPropertyChildren(this, visitor);
        }
    }
}
