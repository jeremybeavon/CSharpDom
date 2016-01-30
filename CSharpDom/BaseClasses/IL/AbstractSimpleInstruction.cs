using System;
using CSharpDom.Common.IL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractSimpleInstruction : ISimpleInstruction
    {
        public abstract SimpleInstructionType InstructionType { get; }

        public void Accept(IILInstructionVisitor visitor)
        {
            ILInstructionVisitor.VisitSimpleInstruction(this, visitor);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
