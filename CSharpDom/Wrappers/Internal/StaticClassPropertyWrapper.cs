using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassPropertyWrapper : AbstractWrapper<IStaticClassProperty>, IStaticClassPropertyWrapper
    {
        public StaticClassPropertyWrapper(IStaticClassProperty property)
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

        public IStaticClassAccessorWrapper GetAccessor
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

        public IStaticClassAccessorWrapper SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public StaticClassMemberVisibilityModifier Visibility
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

        public override void VisitStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            IStaticClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
        }
    }
}
