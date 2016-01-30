using CSharpDom.Common.IL;
using System;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractBranchTargetInstruction : IBranchTargetInstruction
    {
        public abstract int Delta { get; }

        public abstract BranchTargetInstructionType InstructionType { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitBranchTargetInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
