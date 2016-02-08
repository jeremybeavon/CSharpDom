using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        AbstractField<TAttributeGroup, TDeclaringType, TTypeReference>,
        IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TTypeReference : ITypeReference
    {
        public abstract StaticClassFieldModifier Modifier { get; }

        public abstract StaticClassMemberVisibilityModifier Visibility { get; }

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
