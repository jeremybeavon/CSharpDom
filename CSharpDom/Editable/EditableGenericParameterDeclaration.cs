using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Wrappers.Internal;
using System.Collections.Generic;

namespace CSharpDom.Editable
{
    public abstract class EditableGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> :
        AbstractGenericVisitableObject,
        IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>
        where TClassReference : IClassReference
        where TGenericParameterReference : IGenericParameterReference
        where TInterfaceReference : IInterfaceReference
        where TAttributeGroup : IAttributeGroup
    {
        public abstract ICollection<TAttributeGroup> Attributes { get; set; }

        public abstract TClassReference BaseClassConstraint { get; set; }

        public abstract GenericParameterDeclarationDirection Direction { get; set; }

        public abstract ICollection<TGenericParameterReference> GenericParameterConstraints { get; set; }

        public abstract bool HasEmptyConstructorConstraint { get; set; }

        public abstract ICollection<TInterfaceReference> InterfaceConstraints { get; set; }

        public abstract string Name { get; set; }

        public abstract GenericParameterTypeConstraint TypeConstraint { get; set; }

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

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitGenericParameterDeclaration(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitGenericParameterDeclaration(this, visitor);
        }
    }
}
