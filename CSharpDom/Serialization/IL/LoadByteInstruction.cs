using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class LoadByteInstruction : ILoadByteInstruction
    {
        public byte Value { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadByteInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
