using CSharpDom.BaseClasses.IL;
using System.Reflection;
using System;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class LoadMemberTokenInstructionWithReflectionEmit :
        AbstractLoadMemberTokenInstruction<MemberInfo>,
        IILInstructionWithReflectionEmit
    {
        private readonly OpCode opCode;
        private readonly MemberInfo member;
        private readonly int token;

        public LoadMemberTokenInstructionWithReflectionEmit(OpCode opCode, int token, MemberInfo member)
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
