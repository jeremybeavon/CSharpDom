﻿using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using Mono.Cecil.Cil;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class MethodInstructionWithMonoCecilCil : AbstractMethodInstruction<MethodBase>, IILInstructionWithMonoCecilCil
    {
        private static readonly IDictionary<OpCode, MethodInstructionType> instructionTypes =
            new Dictionary<OpCode, MethodInstructionType>()
            {
                { OpCodes.Call, MethodInstructionType.CallMethod },
                { OpCodes.Callvirt, MethodInstructionType.CallVirtualMethod },
                { OpCodes.Jmp, MethodInstructionType.Jump },
                { OpCodes.Ldftn, MethodInstructionType.LoadPointer }, 
                { OpCodes.Ldvirtftn, MethodInstructionType.LoadVirtualPointer },
                { OpCodes.Newobj, MethodInstructionType.NewObject },
            };

        private readonly OpCode opCode;
        private readonly MethodInstructionType instructionType;
        private readonly MethodBase method;
        private readonly int token;

        public MethodInstructionWithMonoCecilCil(OpCode opCode, int token, MethodBase method)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.token = token;
            this.method = method;
        }

        public override MethodBase Method
        {
            get { return method; }
        }

        public override MethodInstructionType InstructionType
        {
            get { return instructionType; }
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
