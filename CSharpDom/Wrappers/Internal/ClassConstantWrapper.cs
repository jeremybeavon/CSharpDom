using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassConstantWrapper : AbstractWrapper<IClassConstant>, IClassConstantWrapper
    {
        public ClassConstantWrapper(IClassConstant field)
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

        public IClassTypeWrapper DeclaringType
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

        public override void VisitClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>(
            IClassConstant<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
        {
            
        }
    }
}
