using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using Mono.Cecil.Cil;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class ShortLocalVariableInstructionWithMonoCecilCil :
        AbstractShortLocalVariableInstruction,
        IILInstructionWithMonoCecilCil
    {
        private static readonly IDictionary<OpCode, ShortLocalVariableInstructionType> instructionTypes =
            new Dictionary<OpCode, ShortLocalVariableInstructionType>()
            {
                { OpCodes.Ldarg_S, ShortLocalVariableInstructionType.LoadArgument },
                { OpCodes.Ldarga_S, ShortLocalVariableInstructionType.LoadArgumentAddress },
                { OpCodes.Ldloc_S, ShortLocalVariableInstructionType.LoadLocalVariable },
                { OpCodes.Ldloca_S, ShortLocalVariableInstructionType.LoadLocalVariableAddress },
                { OpCodes.Starg_S, ShortLocalVariableInstructionType.StoreArgument },
                { OpCodes.Stloc_S, ShortLocalVariableInstructionType.StoreLocalVariable }
            };

        private readonly OpCode opCode;
        private readonly ShortLocalVariableInstructionType instructionType;
        private readonly byte ordinal;

        public ShortLocalVariableInstructionWithMonoCecilCil(OpCode opCode, byte ordinal)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.ordinal = ordinal;
        }

        public override ShortLocalVariableInstructionType InstructionType
        {
            get { return instructionType; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override byte Ordinal
        {
            get { return ordinal; }
        }
    }
}
