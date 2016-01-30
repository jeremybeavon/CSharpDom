namespace CSharpDom.Common.IL
{
    public interface IMethodInstruction<TMethodReference> : IMethodInstruction
    {
        TMethodReference Method { get; }
    }
}
