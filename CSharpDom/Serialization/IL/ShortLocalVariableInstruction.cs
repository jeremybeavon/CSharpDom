using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class ShortLocalVariableInstruction : IShortLocalVariableInstruction
    {
        public ShortLocalVariableInstructionType InstructionType { get; set; }

        public byte Ordinal { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitShortLocalVariableInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
