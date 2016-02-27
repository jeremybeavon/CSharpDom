using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class ShortBranchTargetInstructionWithMonoCecilEmit : AbstractShortBranchTargetInstruction, IILInstructionWithMonoCecilEmit
    {
        private static readonly IDictionary<OpCode, ShortBranchTargetInstructionType> instructionTypes =
            new Dictionary<OpCode, ShortBranchTargetInstructionType>()
            {
                { OpCodes.Br_S, ShortBranchTargetInstructionType.Branch },
                { OpCodes.Beq_S, ShortBranchTargetInstructionType.BranchIfEqual },
                { OpCodes.Brfalse_S, ShortBranchTargetInstructionType.BranchIfFalse },
                { OpCodes.Bgt_S, ShortBranchTargetInstructionType.BranchIfGreaterThan },
                { OpCodes.Bge_S, ShortBranchTargetInstructionType.BranchIfGreaterThanOrEqual },
                { OpCodes.Bge_Un_S, ShortBranchTargetInstructionType.BranchIfGreaterThanOrEqualUnsigned },
                { OpCodes.Bgt_Un_S, ShortBranchTargetInstructionType.BranchIfGreaterThanUnsigned },
                { OpCodes.Blt_S, ShortBranchTargetInstructionType.BranchIfLessThan },
                { OpCodes.Ble_S, ShortBranchTargetInstructionType.BranchIfLessThanOrEqual },
                { OpCodes.Ble_Un_S, ShortBranchTargetInstructionType.BranchIfLessThanOrEqualUnsigned },
                { OpCodes.Blt_Un_S, ShortBranchTargetInstructionType.BranchIfLessThanUnsigned },
                { OpCodes.Bne_Un_S, ShortBranchTargetInstructionType.BranchIfNotEqual },
                { OpCodes.Brtrue_S, ShortBranchTargetInstructionType.BranchIfTrue },
                { OpCodes.Leave_S, ShortBranchTargetInstructionType.Leave }
            };

        private readonly OpCode opCode;
        private readonly ShortBranchTargetInstructionType instructionType;
        private readonly sbyte delta;

        public ShortBranchTargetInstructionWithMonoCecilEmit(OpCode opCode, sbyte delta)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.delta = delta;
        }

        public override sbyte Delta
        {
            get { return delta; }
        }

        public override ShortBranchTargetInstructionType InstructionType
        {
            get { return instructionType; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }
    }
}
