namespace CSharpDom.Common.Editable
{
    public interface IHasEditableBaseClass<TClassReference> : IHasBaseClass<TClassReference>
    {
        new TClassReference BaseClass { get; set; }
    }
}