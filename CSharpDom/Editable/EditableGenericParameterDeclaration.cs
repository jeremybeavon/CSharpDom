using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;

namespace CSharpDom.Editable
{
    public class EditableGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> :
        IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>
        where TClassReference : IClassReference
        where TGenericParameterReference : IGenericParameterReference
        where TInterfaceReference : IInterfaceReference
        where TAttributeGroup : IAttributeGroup
    {
        public virtual ICollection<TAttributeGroup> Attributes { get; set; }

        public virtual TClassReference BaseClassConstraint { get; set; }

        public virtual GenericParameterDeclarationDirection Direction { get; set; }

        public virtual ICollection<TGenericParameterReference> GenericParameterConstraints { get; set; }

        public virtual bool HasEmptyConstructorConstraint { get; set; }

        public virtual ICollection<TInterfaceReference> InterfaceConstraints { get; set; }

        public virtual string Name { get; set; }

        public virtual GenericParameterTypeConstraint TypeConstraint { get; set; }

        IReadOnlyCollection<TAttributeGroup> IHasAttributes<TAttributeGroup>.Attributes
        {
            get { return new ReadOnlyCollectionWrapper<TAttributeGroup>(Attributes); }
        }

        IReadOnlyCollection<TGenericParameterReference> IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>.GenericParameterConstraints
        {
            get { return new ReadOnlyCollectionWrapper<TGenericParameterReference>(GenericParameterConstraints); }
        }

        IReadOnlyCollection<TInterfaceReference> IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>.InterfaceConstraints
        {
            get { return new ReadOnlyCollectionWrapper<TInterfaceReference>(InterfaceConstraints); }
        }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterDeclaration(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameterDeclaration(this, visitor);
        }
    }
}
