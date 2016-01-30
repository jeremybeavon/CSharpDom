using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class LoadIntegerInstructionWithReflectionEmit : AbstractLoadIntegerInstruction, IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly int value;

        public LoadIntegerInstructionWithReflectionEmit(OpCode opCode, int value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override int Value
        {
            get { return value; }
        }
    }
}
