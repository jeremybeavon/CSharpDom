namespace CSharpDom.Common
{
    public interface IAttributeGroup<TAttribute> : IAttributeGroup, IHasAttributes<TAttribute>
        where TAttribute : IAttribute
    {
    }
}
