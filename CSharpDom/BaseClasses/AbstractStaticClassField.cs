using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        AbstractFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public abstract StaticClassFieldModifier Modifier { get; }

        public abstract StaticClassMemberVisibilityModifier InheritanceModifier { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}
