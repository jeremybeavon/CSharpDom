using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class LocalVariableInstruction : ILocalVariableInstruction
    {
        public LocalVariableInstructionType InstructionType { get; set; }

        public ushort Ordinal { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitLocalVariableInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
