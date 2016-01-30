using System;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class LoadLongInstruction : ILoadLongInstruction
    {
        public long Value { get; set; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitLoadLongInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
