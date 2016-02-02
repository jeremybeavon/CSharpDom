namespace CSharpDom.Common
{
    public interface IClassAccessor<TAttributeGroup, TMethodBody> :
        IClassAccessor,
        IAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
