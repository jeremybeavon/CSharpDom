using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLoadByteInstruction : ILoadByteInstruction
    {
        public abstract byte Value { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadByteInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
