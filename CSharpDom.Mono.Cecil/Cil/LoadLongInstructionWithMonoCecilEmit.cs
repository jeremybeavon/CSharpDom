using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadLongInstructionWithMonoCecilEmit : AbstractLoadLongInstruction, IILInstructionWithMonoCecilEmit
    {
        private readonly OpCode opCode;
        private readonly long value;

        public LoadLongInstructionWithMonoCecilEmit(OpCode opCode, long value)
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
