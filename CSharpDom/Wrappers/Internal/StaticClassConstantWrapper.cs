using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassConstantWrapper : AbstractWrapper<IStaticClassConstant>, IStaticClassConstantWrapper
    {
        public StaticClassConstantWrapper(IStaticClassConstant field)
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

        public IStaticTypeWrapper DeclaringType
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

        public override void VisitStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IStaticClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
        }
    }
}
