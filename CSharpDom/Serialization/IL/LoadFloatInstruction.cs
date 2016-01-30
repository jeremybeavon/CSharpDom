using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class LoadFloatInstruction : ILoadFloatInstruction
    {
        public float Value { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadFloatInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
