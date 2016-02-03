using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class GenericParameterDeclaration :
        IGenericParameterDeclaration<
            ClassReference,
            GenericParameterReference,
            InterfaceReference,
            AttributeGroup>
    {
        public List<AttributeGroup> Attributes { get; set; }

        public ClassReference BaseClassConstraint { get; set; }

        public GenericParameterDeclarationDirection Direction { get; set; }

        public List<GenericParameterReference> GenericParameterConstraints { get; set; }

        public bool HasEmptyConstructorConstraint { get; set; }

        public List<InterfaceReference> InterfaceConstraints { get; set; }

        public string Name { get; set; }

        public GenericParameterTypeConstraint TypeConstraint { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAttributes<AttributeGroup>.Attributes
        {
            get { return Attributes; }
        }

        IReadOnlyCollection<GenericParameterReference> IGenericParameterDeclaration<ClassReference, GenericParameterReference, InterfaceReference, AttributeGroup>.GenericParameterConstraints
        {
            get { return GenericParameterConstraints; }
        }

        IReadOnlyCollection<InterfaceReference> IGenericParameterDeclaration<ClassReference, GenericParameterReference, InterfaceReference, AttributeGroup>.InterfaceConstraints
        {
            get { return InterfaceConstraints; }
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
