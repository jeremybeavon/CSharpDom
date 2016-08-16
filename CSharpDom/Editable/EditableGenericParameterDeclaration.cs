using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Editable
{
    public class EditableGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> :
        IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>
        where TClassReference : IClassReference
        where TGenericParameterReference : IGenericParameterReference
        where TInterfaceReference : IInterfaceReference
        where TAttributeGroup : IAttributeGroup
    {
        public virtual IReadOnlyCollection<TAttributeGroup> Attributes { get; set; }

        public virtual TClassReference BaseClassConstraint { get; set; }

        public virtual GenericParameterDeclarationDirection Direction { get; set; }

        public virtual IReadOnlyCollection<TGenericParameterReference> GenericParameterConstraints { get; set; }

        public virtual bool HasEmptyConstructorConstraint { get; set; }

        public virtual IReadOnlyCollection<TInterfaceReference> InterfaceConstraints { get; set; }

        public virtual string Name { get; set; }

        public virtual GenericParameterTypeConstraint TypeConstraint { get; set; }

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
