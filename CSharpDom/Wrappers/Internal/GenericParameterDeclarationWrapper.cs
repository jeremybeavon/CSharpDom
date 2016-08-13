using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class GenericParameterDeclarationWrapper : AbstractWrapper<IGenericParameterDeclaration>, IGenericParameterDeclarationWrapper
    {
        public GenericParameterDeclarationWrapper(IGenericParameterDeclaration genericParameterDeclaration)
            : base(genericParameterDeclaration)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassReferenceWrapper BaseClassConstraint
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public GenericParameterDeclarationDirection Direction
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IGenericParameterReferenceWrapper> GenericParameterConstraints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool HasEmptyConstructorConstraint
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IInterfaceReferenceWrapper> InterfaceConstraints
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public GenericParameterTypeConstraint TypeConstraint
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Accept(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public override void VisitGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup>(
            IGenericParameterDeclaration<TClassReference, TGenericParameterReference, TInterfaceReference, TAttributeGroup> genericParameterDeclaration)
        {
        }
    }
}
