using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructConstantWrapper : AbstractWrapper<IStructConstant>, IStructConstantWrapper
    {
        public StructConstantWrapper(IStructConstant field)
            : base(field)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IConstantWrapper> Constants
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ITypeReferenceWrapper FieldType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StructMemberVisibilityModifier Visibility
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

        public override void VisitStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStructConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
        }
    }
}
