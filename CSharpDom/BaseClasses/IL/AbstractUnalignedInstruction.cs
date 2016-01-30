using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractUnalignedInstruction : IUnalignedInstruction
    {
        public abstract byte Value { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitUnalignedInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
