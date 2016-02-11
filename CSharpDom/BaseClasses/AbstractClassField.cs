using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        AbstractField<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IClassType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public abstract ClassFieldModifier Modifier { get; }

        public abstract ClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitClassField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}
