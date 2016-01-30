using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class LoadIntegerInstruction : ILoadIntegerInstruction
    {
        public int Value { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadIntegerInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
