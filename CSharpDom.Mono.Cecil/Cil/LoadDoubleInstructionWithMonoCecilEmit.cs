using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadDoubleInstructionWithMonoCecilCil : AbstractLoadDoubleInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly double value;

        public LoadDoubleInstructionWithMonoCecilCil(OpCode opCode, double value)
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
