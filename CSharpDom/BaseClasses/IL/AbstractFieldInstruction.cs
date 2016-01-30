using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractFieldInstruction : IFieldInstruction
    {
        public abstract FieldInstructionType InstructionType { get; }
        public abstract int Token { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitFieldInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
