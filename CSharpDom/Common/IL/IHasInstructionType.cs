namespace CSharpDom.Common.IL
{
    public interface IHasInstructionType<TInstructionType>
    {
        TInstructionType InstructionType { get; }
    }
}
