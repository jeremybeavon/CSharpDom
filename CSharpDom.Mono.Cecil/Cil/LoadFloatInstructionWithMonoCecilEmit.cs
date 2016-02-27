using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadFloatInstructionWithMonoCecilEmit : AbstractLoadFloatInstruction, IILInstructionWithMonoCecilEmit
    {
        private readonly OpCode opCode;
        private readonly float value;

        public LoadFloatInstructionWithMonoCecilEmit(OpCode opCode, float value)
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
