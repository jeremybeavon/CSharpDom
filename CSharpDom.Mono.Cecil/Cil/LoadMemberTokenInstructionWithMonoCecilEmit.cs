using CSharpDom.BaseClasses.IL;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadMemberTokenInstructionWithMonoCecilCil :
        AbstractLoadMemberTokenInstruction<MemberReference>,
        IILInstructionWithMonoCecilCil
    {
        private readonly OpCode opCode;
        private readonly MemberReference member;
        private readonly int token;

        public LoadMemberTokenInstructionWithMonoCecilCil(OpCode opCode, int token, MemberReference member)
        {
            this.opCode = opCode;
            this.token = token;
            this.member = member;
        }

        public override MemberReference Member
        {
            get { return member; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override int Token
        {
            get { return token; }
        }
    }
}
