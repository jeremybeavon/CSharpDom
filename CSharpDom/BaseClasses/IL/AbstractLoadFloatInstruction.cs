using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLoadFloatInstruction : ILoadFloatInstruction
    {
        public abstract float Value { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadFloatInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
