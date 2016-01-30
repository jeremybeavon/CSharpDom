using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLocalVariableInstruction : ILocalVariableInstruction
    {
        public abstract LocalVariableInstructionType InstructionType { get; }

        public abstract ushort Ordinal { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitLocalVariableInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
