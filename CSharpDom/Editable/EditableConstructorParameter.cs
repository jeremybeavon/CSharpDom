using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public abstract class EditableConstructorParameter<TAttributeGroup, TTypeReference> :
        EditableParameter<TAttributeGroup, TTypeReference>,
        IConstructorParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract ParameterModifier Modifier { get; set; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitConstructorParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitConstructorParameterChildren(this, visitor);
        }
    }
}
