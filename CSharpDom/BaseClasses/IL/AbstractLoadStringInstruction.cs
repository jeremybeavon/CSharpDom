using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractLoadStringInstruction : ILoadStringInstruction
    {
        public abstract int Token { get; }

        public abstract string Value { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadStringInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
