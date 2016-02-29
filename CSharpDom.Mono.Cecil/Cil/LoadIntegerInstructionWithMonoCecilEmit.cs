using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadIntegerInstructionWithMonoCecilCil : AbstractLoadIntegerInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly int value;

        public LoadIntegerInstructionWithMonoCecilCil(OpCode opCode, int value)
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
