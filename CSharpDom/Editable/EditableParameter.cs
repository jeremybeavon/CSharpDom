using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public abstract class EditableParameter<TAttributeGroup, TTypeReference> : IParameter<TAttributeGroup, TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TTypeReference : ITypeReference
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }
        
        public abstract string Name { get; set; }

        public abstract TTypeReference ParameterType { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

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
