using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class FieldInstructionWithMonoCecilEmit : AbstractFieldInstruction<FieldInfo>, IILInstructionWithMonoCecilEmit
    {
        private static readonly IDictionary<OpCode, FieldInstructionType> instructionTypes =
            new Dictionary<OpCode, FieldInstructionType>()
            {
                { OpCodes.Ldfld, FieldInstructionType.LoadField },
                { OpCodes.Ldflda, FieldInstructionType.LoadFieldAddress },
                { OpCodes.Ldsfld, FieldInstructionType.LoadStaticField },
                { OpCodes.Ldsflda, FieldInstructionType.LoadStaticFieldAddress },
                { OpCodes.Stfld, FieldInstructionType.StoreField },
                { OpCodes.Stsfld, FieldInstructionType.StoreStaticField }
            };

        private readonly OpCode opCode;
        private readonly FieldInstructionType instructionType;
        private readonly FieldInfo field;
        private readonly int token;

        public FieldInstructionWithMonoCecilEmit(OpCode opCode, int token, FieldInfo field)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.token = token;
            this.field = field;
        }

        public override FieldInfo Field
        {
            get { return field; }
        }

        public override FieldInstructionType InstructionType
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
