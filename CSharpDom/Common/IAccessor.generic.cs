namespace CSharpDom.Common
{
    public interface IAccessor<TAttributeGroup, TMethodBody> :
        IAccessor,
        IHasMemberVisibilityModifier,
        IHasAttributes<TAttributeGroup>,
        IHasBody<TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
