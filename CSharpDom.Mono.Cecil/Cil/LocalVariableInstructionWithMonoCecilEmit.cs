using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class LocalVariableInstructionWithMonoCecilEmit :
        AbstractLocalVariableInstruction,
        IILInstructionWithMonoCecilEmit
    {
        private static readonly IDictionary<OpCode, LocalVariableInstructionType> instructionTypes =
            new Dictionary<OpCode, LocalVariableInstructionType>()
            {
                { OpCodes.Ldarg, LocalVariableInstructionType.LoadArgument },
                { OpCodes.Ldarga, LocalVariableInstructionType.LoadArgumentAddress },
                { OpCodes.Ldloc, LocalVariableInstructionType.LoadLocalVariable },
                { OpCodes.Ldloca, LocalVariableInstructionType.LoadLocalVariableAddress },
                { OpCodes.Starg, LocalVariableInstructionType.StoreArgument },
                { OpCodes.Stloc, LocalVariableInstructionType.StoreLocalVariable }
            };

        private readonly OpCode opCode;
        private readonly LocalVariableInstructionType instructionType;
        private readonly ushort ordinal;

        public LocalVariableInstructionWithMonoCecilEmit(OpCode opCode, ushort ordinal)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.ordinal = ordinal;
        }

        public override LocalVariableInstructionType InstructionType
        {
            get { return instructionType; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }

        public override ushort Ordinal
        {
            get { return ordinal; }
        }
    }
}
