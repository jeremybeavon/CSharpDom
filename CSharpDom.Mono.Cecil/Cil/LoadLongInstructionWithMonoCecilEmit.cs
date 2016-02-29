using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadLongInstructionWithMonoCecilCil : AbstractLoadLongInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly long value;

        public LoadLongInstructionWithMonoCecilCil(OpCode opCode, long value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override long Value
        {
            get { return value; }
        }
    }
}
