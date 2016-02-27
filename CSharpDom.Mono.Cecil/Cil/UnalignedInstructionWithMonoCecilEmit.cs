using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class UnalignedInstructionWithMonoCecilEmit : AbstractUnalignedInstruction, IILInstructionWithMonoCecilEmit
    {
        private readonly OpCode opCode;
        private readonly byte value;

        public UnalignedInstructionWithMonoCecilEmit(OpCode opCode, byte value)
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
