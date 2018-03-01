using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Expressions;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression> :
        AbstractAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>,
        ISealedClassAutoProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor, TExpression>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
        where TAccessor : IClassAccessor
        where TExpression : IExpression
    {
        public abstract SealedClassMemberInheritanceModifier InheritanceModifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassAutoProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
