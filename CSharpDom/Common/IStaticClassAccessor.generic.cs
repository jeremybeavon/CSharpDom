namespace CSharpDom.Common
{
    public interface IStaticClassAccessor<TAttributeGroup, TMethodBody> :
        IStaticClassAccessor,
        IAccessor<TAttributeGroup, TMethodBody>,
        IHasStaticClassAccessorVisibilityModifier
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
