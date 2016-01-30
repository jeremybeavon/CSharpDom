using CSharpDom.BaseClasses.IL;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class SwitchInstructionWithReflectionEmit : AbstractSwitchInstruction, IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly IReadOnlyList<int> deltas;

        public SwitchInstructionWithReflectionEmit(OpCode opCode, IReadOnlyList<int> deltas)
        {
            this.opCode = opCode;
            this.deltas = deltas;
        }

        public override IReadOnlyList<int> Deltas
        {
            get { return deltas; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }
    }
}
