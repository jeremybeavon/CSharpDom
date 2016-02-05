namespace CSharpDom.Common
{
    public interface ISealedClassAccessor<TAttributeGroup, TMethodBody> :
        ISealedClassAccessor,
        IAccessor<TAttributeGroup, TMethodBody>
        where TAttributeGroup : IAttributeGroup
        where TMethodBody : IMethodBody
    {
    }
}
