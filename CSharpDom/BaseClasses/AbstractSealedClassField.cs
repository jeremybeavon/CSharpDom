using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractSealedClassField<TAttributeGroup, TDeclaringType, TTypeReference> :
        AbstractField<TAttributeGroup, TDeclaringType, TTypeReference>,
        ISealedClassField<TAttributeGroup, TDeclaringType, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : ISealedType
        where TTypeReference : ITypeReference
    {
        public abstract ClassFieldModifier Modifier { get; }

        public abstract SealedClassMemberVisibilityModifier Visibility { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitSealedClassField(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}
