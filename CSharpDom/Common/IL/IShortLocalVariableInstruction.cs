namespace CSharpDom.Common.IL
{
    public interface IShortLocalVariableInstruction : IILInstruction, IHasInstructionType<ShortLocalVariableInstructionType>
    {
        byte Ordinal { get; }
    }
}
