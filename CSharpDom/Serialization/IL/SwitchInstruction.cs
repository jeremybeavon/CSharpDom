using System;
using System.Collections.Generic;
using CSharpDom.Common.IL;

namespace CSharpDom.Serialization.IL
{
    public sealed class SwitchInstruction : ISwitchInstruction
    {
        public SwitchInstruction()
        {
            Deltas = new List<int>();
        }
        
        public List<int> Deltas { get; set; }

        IReadOnlyList<int> ISwitchInstruction.Deltas
        {
            get { return Deltas; }
        }

        public void Accept(IILInstructionVisitor visitor)
        {
            visitor.VisitSwitchInstruction(this);
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
