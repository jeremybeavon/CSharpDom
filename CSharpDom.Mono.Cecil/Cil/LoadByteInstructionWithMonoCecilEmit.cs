using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadByteInstructionWithMonoCecilCil : AbstractLoadByteInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly byte value;

        public LoadByteInstructionWithMonoCecilCil(OpCode opCode, byte value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override byte Value
        {
            get { return value; }
        }
    }
}
