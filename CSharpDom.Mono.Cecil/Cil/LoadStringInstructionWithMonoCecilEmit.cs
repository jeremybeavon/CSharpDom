using CSharpDom.BaseClasses.IL;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadStringInstructionWithMonoCecilCil : AbstractLoadStringInstruction, IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly int token;
        private readonly string value;

        public LoadStringInstructionWithMonoCecilCil(OpCode opCode, int token, string value)
        {
            this.opCode = opCode;
            this.token = token;
            this.value = value;
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override int Token
        {
            get { return token; }
        }

        public override string Value
        {
            get { return value; }
        }
    }
}
