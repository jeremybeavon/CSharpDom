using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class LoadLongInstructionWithReflectionEmit : AbstractLoadLongInstruction, IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly long value;

        public LoadLongInstructionWithReflectionEmit(OpCode opCode, long value)
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
