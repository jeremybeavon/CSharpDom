using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLoadDoubleInstruction : ILoadDoubleInstruction
    {
        public abstract double Value { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadDoubleInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
