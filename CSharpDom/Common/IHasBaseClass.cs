namespace CSharpDom.Common
{
    public interface IHasBaseClass<TClassReference>
    {
        TClassReference BaseClass { get; }
    }
}
