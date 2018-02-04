namespace CSharpDom.Common.Editable
{
    public interface IHasEditableDeclaringType<TDeclaringType> : IHasDeclaringType<TDeclaringType>
    {
        new TDeclaringType DeclaringType { get; set; }
    }
}