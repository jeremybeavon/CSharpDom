namespace CSharpDom.Common.IL
{
    public interface ITypeInstruction<TTypeReference> : ITypeInstruction
    {
        TTypeReference Type { get; }
    }
}
