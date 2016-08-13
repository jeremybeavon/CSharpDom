using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class SealedClassPropertyWrapper : AbstractWrapper<ISealedClassProperty>, ISealedClassPropertyWrapper
    {
        public SealedClassPropertyWrapper(ISealedClassProperty property)
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

        public ISealedTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IClassAccessorWrapper GetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public SealedClassMemberInheritanceModifier InheritanceModifier
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

        public IClassAccessorWrapper SetAccessor
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public ClassMemberVisibilityModifier Visibility
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

        public override void VisitSealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor>(
            ISealedClassProperty<TAttributeGroup, TDeclaringType, TTypeReference, TAccessor> property)
        {
        }
    }
}
