using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLoadLongInstruction : ILoadLongInstruction
    {
        public abstract long Value { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadLongInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
