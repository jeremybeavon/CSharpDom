using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractShortLocalVariableInstruction : IShortLocalVariableInstruction
    {
        public abstract ShortLocalVariableInstructionType InstructionType { get; }

        public abstract byte Ordinal { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitShortLocalVariableInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
