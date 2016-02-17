using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses.Wrappers
{
    public sealed class ConstantGroupWrapper<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> :
        AbstractConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>,
        IWrapper<IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant>>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
        where TConstant : IConstant
    {
        public ConstantGroupWrapper(IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> field)
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

        public override IReadOnlyCollection<TConstant> Constants
        {
            get { return WrappedObject.Constants; }
        }

        public override TTypeReference FieldType
        {
            get { return WrappedObject.FieldType; }
        }
        
        public IConstantGroup<TAttributeGroup, TDeclaringType, TTypeReference, TConstant> WrappedObject { get; private set; }
    }
}
