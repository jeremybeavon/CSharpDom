using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableParameter<TAttributeGroup, TTypeReference> : IParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }
        
        public virtual string Name { get; set; }

        public virtual TTypeReference ParameterType { get; set; }

        public virtual void Accept(IGenericVisitor visitor)
        {
            visitor.VisitParameter(this);
        }

        public virtual void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitParameterChildren(this, visitor);
        }
    }
}
