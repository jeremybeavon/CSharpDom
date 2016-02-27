using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadIntegerInstructionWithMonoCecilEmit : AbstractLoadIntegerInstruction, IILInstructionWithMonoCecilEmit
    {
        private readonly OpCode opCode;
        private readonly int value;

        public LoadIntegerInstructionWithMonoCecilEmit(OpCode opCode, int value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override int Value
        {
            get { return value; }
        }
    }
}
