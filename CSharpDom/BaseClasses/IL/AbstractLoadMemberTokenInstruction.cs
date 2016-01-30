using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{

    public abstract class AbstractLoadMemberTokenInstruction : ILoadMemberTokenInstruction
    {
        public abstract int Token { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadMemberTokenInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
