using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{

    public abstract class AbstractTypeInstruction : ITypeInstruction
    {
        public abstract TypeInstructionType InstructionType { get; }

        public abstract int Token { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitTypeInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
