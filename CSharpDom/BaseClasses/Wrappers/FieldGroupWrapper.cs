using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class FieldGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TField> :
        AbstractFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>,
        IWrapper<IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TField : IField
    {
        public FieldGroupWrapper(IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> field)
        {
            WrappedObject = field;
        }

        public override IReadOnlyCollection<TAttributeGroup> Attributes
        {
            get { return WrappedObject.Attributes; }
        }

        public override TDeclaringType DeclaringType
        {
            get { return WrappedObject.DeclaringType; }
        }

        public override IReadOnlyCollection<TField> Fields
        {
            get { return WrappedObject.Fields; }
        }

        public override TTypeReference FieldType
        {
            get { return WrappedObject.FieldType; }
        }
        
        public IFieldGroup<TAttributeGroup, TDeclaringType, TTypeReference, TField> WrappedObject { get; private set; }
    }
}
