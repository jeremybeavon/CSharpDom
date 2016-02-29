using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class SwitchInstructionWithMonoCecilCil : AbstractSwitchInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly IReadOnlyList<int> deltas;

        public SwitchInstructionWithMonoCecilCil(OpCode opCode, IReadOnlyList<int> deltas)
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
