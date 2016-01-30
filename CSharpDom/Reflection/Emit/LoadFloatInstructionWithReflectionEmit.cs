using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class LoadFloatInstructionWithReflectionEmit : AbstractLoadFloatInstruction, IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly float value;

        public LoadFloatInstructionWithReflectionEmit(OpCode opCode, float value)
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
