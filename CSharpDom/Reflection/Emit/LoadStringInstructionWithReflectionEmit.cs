using CSharpDom.BaseClasses.IL;
using System.Reflection.Emit;
using System;

namespace CSharpDom.Reflection.Emit
{
    public sealed class LoadStringInstructionWithReflectionEmit : AbstractLoadStringInstruction, IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly string value;

        public LoadStringInstructionWithReflectionEmit(OpCode opCode, int token, string value)
        {
            this.opCode = opCode;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override int Token
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Value
        {
            get { return value; }
        }
    }
}
