namespace CSharpDom.Common.IL
{
    public interface IFieldInstruction<TFieldReference> : IFieldInstruction
    {
        TFieldReference Field { get; }
    }
}
