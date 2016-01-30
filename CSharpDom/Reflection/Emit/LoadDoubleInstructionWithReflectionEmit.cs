using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class LoadDoubleInstructionWithReflectionEmit : AbstractLoadDoubleInstruction, IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly double value;

        public LoadDoubleInstructionWithReflectionEmit(OpCode opCode, double value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override double Value
        {
            get { return value; }
        }
    }
}
