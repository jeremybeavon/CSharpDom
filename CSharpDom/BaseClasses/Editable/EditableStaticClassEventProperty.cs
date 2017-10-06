using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody> :
        EditableEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>,
        IStaticClassEventProperty<TAttributeGroup, TDeclaringType, TDelegateReference, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IStaticType
        where TDelegateReference : IDelegateReference
        where TMethodBody : IMethodBody
    {
        public abstract StaticClassMemberVisibilityModifier Visibility { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStaticClassEventProperty(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStaticClassEventPropertyChildren(this, visitor);
        }
    }
}
