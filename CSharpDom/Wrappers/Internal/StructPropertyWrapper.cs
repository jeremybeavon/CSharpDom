using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StructPropertyWrapper : AbstractWrapper<IStructProperty>, IStructPropertyWrapper
    {
        public StructPropertyWrapper(IStructProperty property)
            : base(property)
        {
        }

        public IReadOnlyCollection<IAttributeGroupWrapper> Attributes
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

        public IStructAccessorWrapper GetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StructMemberInheritanceModifier InheritanceModifier
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

        public ITypeReferenceWrapper PropertyType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IStructAccessorWrapper SetAccessor
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

        public override void VisitStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStructProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
        }
    }
}
