﻿namespace CSharpDom.Common
{
    public interface IField<TAttributeGroup, TDeclaringType, TTypeReference> :
        IField,
        IHasName,
        IHasMemberVisibilityModifier,
        IHasFieldModifier,
        IHasAttributes<TAttributeGroup>,
        IHasDeclaringType<TDeclaringType>,
        IHasFieldType<TTypeReference>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TTypeReference : ITypeReference
    {
    }
}
