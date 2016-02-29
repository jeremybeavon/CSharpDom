using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class UnalignedInstructionWithMonoCecilCil : AbstractUnalignedInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly byte value;

        public UnalignedInstructionWithMonoCecilCil(OpCode opCode, byte value)
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
