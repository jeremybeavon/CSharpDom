using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadFloatInstructionWithMonoCecilCil : AbstractLoadFloatInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly float value;

        public LoadFloatInstructionWithMonoCecilCil(OpCode opCode, float value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override float Value
        {
            get { return value; }
        }
    }
}
