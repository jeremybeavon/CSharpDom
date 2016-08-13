using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers.Internal
{
    internal sealed class StaticClassFieldWrapper : AbstractWrapper<IStaticClassField>, IStaticClassFieldWrapper
    {
        public StaticClassFieldWrapper(IStaticClassField field)
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

        public IStaticTypeWrapper DeclaringType
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

        public StaticClassFieldModifier Modifier
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

        public override void VisitStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field>(
            IStaticClassField<TAttributeGroup, TDeclaringType, TTypeReference, Field> field)
        {
        }
    }
}
