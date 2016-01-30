using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class LoadStringInstruction : ILoadStringInstruction
    {
        public int Token { get; set; }

        public string Value { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadStringInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
