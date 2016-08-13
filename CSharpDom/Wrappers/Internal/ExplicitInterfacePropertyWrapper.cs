using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ExplicitInterfacePropertyWrapper : AbstractWrapper<IExplicitInterfaceProperty>, IExplicitInterfacePropertyWrapper
    {
        public ExplicitInterfacePropertyWrapper(IExplicitInterfaceProperty property)
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

        public ITypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IInterfaceReferenceWrapper ExplicitInterface
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAccessorWrapper GetAccessor
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

        public IAccessorWrapper SetAccessor
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

        public override void VisitExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor>(
            IExplicitInterfaceProperty<TAttributeGroup, TDeclaringType, TInterfaceReference, TTypeReference, TAccessor> property)
        {
        }
    }
}
