using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class ClassFieldWrapper : AbstractWrapper<IClassField>, IClassFieldWrapper
    {
        public ClassFieldWrapper(IClassField field)
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

        public IClassTypeWrapper DeclaringType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IReadOnlyCollection<IFieldWrapper> Fields
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

        public ClassFieldModifier Modifier
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

        public override void VisitClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField>(
            IClassField<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            
        }
        
    }
}
