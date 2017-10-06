using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableExtensionParameter<TAttributeGroup, TTypeReference> :
        EditableParameter<TAttributeGroup, TTypeReference>,
        IExtensionParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitExtensionParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitExtensionParameterChildren(this, visitor);
        }
    }
}
