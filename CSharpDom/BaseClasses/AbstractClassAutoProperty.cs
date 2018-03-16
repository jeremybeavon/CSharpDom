using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        AbstractAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>,
        IClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAutoPropertyAccessor
        where TExpression : IExpression
    {
        public abstract ClassMemberInheritanceModifier InheritanceModifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassAutoProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitClassAutoPropertyChildren(this, visitor);
        }
    }
}
