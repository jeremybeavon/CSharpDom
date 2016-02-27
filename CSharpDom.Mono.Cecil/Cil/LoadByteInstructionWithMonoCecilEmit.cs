using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadByteInstructionWithMonoCecilEmit : AbstractLoadByteInstruction, IILInstructionWithMonoCecilEmit
    {
        private readonly OpCode opCode;
        private readonly byte value;

        public LoadByteInstructionWithMonoCecilEmit(OpCode opCode, byte value)
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
