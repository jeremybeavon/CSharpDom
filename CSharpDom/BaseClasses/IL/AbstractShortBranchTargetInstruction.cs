using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractShortBranchTargetInstruction : IShortBranchTargetInstruction
    {
        public abstract sbyte Delta { get; }

        public abstract ShortBranchTargetInstructionType InstructionType { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitShortBranchTargetInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
