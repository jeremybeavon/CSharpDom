namespace CSharpDom.Common
{
    public interface IStructAccessor<TAttributeGroup, TMethodBody> :
        IStructAccessor,
        IAccessor<TAttributeGroup, TMethodBody>,
        IHasStructAccessorVisibilityModifier
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
