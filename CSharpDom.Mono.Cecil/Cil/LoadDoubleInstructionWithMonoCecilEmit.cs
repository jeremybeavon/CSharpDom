using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadDoubleInstructionWithMonoCecilEmit : AbstractLoadDoubleInstruction, IILInstructionWithMonoCecilEmit
    {
        private readonly OpCode opCode;
        private readonly double value;

        public LoadDoubleInstructionWithMonoCecilEmit(OpCode opCode, double value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override double Value
        {
            get { return value; }
        }
    }
}
