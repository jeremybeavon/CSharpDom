using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableMethodParameter<TAttributeGroup, TTypeReference> :
        EditableParameter<TAttributeGroup, TTypeReference>,
        IMethodParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract ParameterModifier Modifier { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitMethodParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitMethodParameterChildren(this, visitor);
        }
    }
}
