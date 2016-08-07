namespace CSharpDom.Common
{
    public interface IClassAccessor<TAttributeGroup, TMethodBody> :
        IClassAccessor,
        IAccessor<TAttributeGroup, TMethodBody>,
        IHasClassAccessorVisibilityModifier
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
