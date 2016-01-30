using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class SimpleInstruction : ISimpleInstruction
    {
        public SimpleInstructionType InstructionType { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitSimpleInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
