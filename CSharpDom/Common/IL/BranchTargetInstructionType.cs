namespace CSharpDom.Common.IL
{
    public enum BranchTargetInstructionType
    {
        BranchIfEqual,
        BranchIfGreaterThanOrEqual,
        BranchIfGreaterThanOrEqualUnsigned,
        BranchIfGreaterThan,
        BranchIfGreaterThanUnsigned,
        BranchIfLessThanOrEqual,
        BranchIfLessThanOrEqualUnsigned,
        BranchIfLessThan,
        BranchIfLessThanUnsigned,
        BranchIfNotEqual,
        Branch,
        BranchIfFalse,
        BranchIfTrue,
        Leave
    }
}
