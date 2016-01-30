using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class UnalignedInstruction : IUnalignedInstruction
    {
        public byte Value { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitUnalignedInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
