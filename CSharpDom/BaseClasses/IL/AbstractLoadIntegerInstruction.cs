using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLoadIntegerInstruction : ILoadIntegerInstruction
    {
        public abstract int Value { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadIntegerInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
