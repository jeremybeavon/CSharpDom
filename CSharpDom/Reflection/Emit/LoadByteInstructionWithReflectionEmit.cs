using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class LoadByteInstructionWithReflectionEmit : AbstractLoadByteInstruction, IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly byte value;

        public LoadByteInstructionWithReflectionEmit(OpCode opCode, byte value)
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
