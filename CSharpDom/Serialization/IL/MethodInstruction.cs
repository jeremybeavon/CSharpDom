using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class MethodInstruction : IMethodInstruction
    {
        public MethodInstructionType InstructionType { get; set; }

        public int Token { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitMethodInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
