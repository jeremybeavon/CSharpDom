using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableDelegateParameter<TAttributeGroup, TTypeReference> :
        EditableParameter<TAttributeGroup, TTypeReference>,
        IDelegateParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract ParameterModifier Modifier { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitDelegateParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitDelegateParameterChildren(this, visitor);
        }
    }
}
