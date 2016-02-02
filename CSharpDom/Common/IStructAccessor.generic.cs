namespace CSharpDom.Common
{
    public interface IStructAccessor<TAttributeGroup, TMethodBody> :
        IStructAccessor,
        IAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
