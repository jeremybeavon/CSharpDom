using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using Mono.Cecil;
using Mono.Cecil.Cil;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class FieldInstructionWithMonoCecilCil : AbstractFieldInstruction<FieldDefinition>, IILInstructionWithMonoCecilCil
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
        private readonly FieldDefinition field;
        private readonly int token;

        public FieldInstructionWithMonoCecilCil(OpCode opCode, int token, FieldDefinition field)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.token = token;
            this.field = field;
        }

        public override FieldDefinition Field
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
