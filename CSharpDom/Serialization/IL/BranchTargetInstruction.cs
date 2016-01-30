using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class BranchTargetInstruction : IBranchTargetInstruction
    {
        public int Delta { get; set; }

        public BranchTargetInstructionType InstructionType { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitBranchTargetInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
