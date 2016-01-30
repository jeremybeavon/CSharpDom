namespace CSharpDom.Common.IL
{
    public interface ILocalVariableInstruction : IILInstruction, IHasInstructionType<LocalVariableInstructionType>
    {
        ushort Ordinal { get; }
    }
}
