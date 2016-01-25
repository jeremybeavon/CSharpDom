namespace CSharpDom.Common
{
    public interface IConstructor<TAttributeGroup, TDeclaringType, TParameter> :
        IConstructor,
        IHasAttributes<TAttributeGroup>,
        IHasMemberVisibilityModifier,
        IHasDeclaringType<TDeclaringType>,
        IHasParameters<TParameter>
        where TAttributeGroup : IAttributeGroup
        where TDeclaringType : IType
        where TParameter : IParameter
    {
    }
}
