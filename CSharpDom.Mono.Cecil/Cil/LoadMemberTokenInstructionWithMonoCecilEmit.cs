using CSharpDom.BaseClasses.IL;
using System.Reflection;
using System;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LoadMemberTokenInstructionWithMonoCecilEmit :
        AbstractLoadMemberTokenInstruction<MemberInfo>,
        IILInstructionWithMonoCecilEmit
    {
        private readonly OpCode opCode;
        private readonly MemberInfo member;
        private readonly int token;

        public LoadMemberTokenInstructionWithMonoCecilEmit(OpCode opCode, int token, MemberInfo member)
        {
            this.opCode = opCode;
            this.token = token;
            this.member = member;
        }

        public override MemberInfo Member
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
