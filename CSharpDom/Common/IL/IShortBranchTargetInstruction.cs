namespace CSharpDom.Common.IL
{
    public interface IShortBranchTargetInstruction : IILInstruction, IHasInstructionType<ShortBranchTargetInstructionType>
    {
        sbyte Delta { get; }
    }
}
