using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableParameter<TAttributeGroup, TTypeReference> :
        AbstractGenericVisitableObject,
        IParameter<TAttributeGroup, TTypeReference>
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

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitParameter(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitParameterChildren(this, visitor);
        }
    }
}
