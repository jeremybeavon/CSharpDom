using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class LoadMemberTokenInstruction : ILoadMemberTokenInstruction
    {
        public int Token { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadMemberTokenInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
