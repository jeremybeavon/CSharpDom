namespace CSharpDom.Common.IL
{
    public interface IBranchTargetInstruction : IILInstruction, IHasInstructionType<BranchTargetInstructionType>
    {
        int Delta { get; }
    }
}
