namespace CSharpDom.Common.Editable
{
    public interface IHasEditableStaticConstructor<TStaticConstructor> : IHasStaticConstructor<TStaticConstructor>
    {
        new TStaticConstructor StaticConstructor { get; set; }
    }
}