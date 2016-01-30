using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class ShortBranchTargetInstruction : IShortBranchTargetInstruction
    {
        public sbyte Delta { get; set; }

        public ShortBranchTargetInstructionType InstructionType { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitShortBranchTargetInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
