using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class ShortBranchTargetInstructionWithReflectionEmit : AbstractShortBranchTargetInstruction, IILInstructionWithReflectionEmit
    {
        private static readonly IDictionary<OpCode, ShortBranchTargetInstructionType> instructionTypes =
            new Dictionary<OpCode, ShortBranchTargetInstructionType>()
            {
                { OpCodes.Br, ShortBranchTargetInstructionType.Branch },
                { OpCodes.Beq, ShortBranchTargetInstructionType.BranchIfEqual },
                { OpCodes.Brfalse, ShortBranchTargetInstructionType.BranchIfFalse },
                { OpCodes.Bgt, ShortBranchTargetInstructionType.BranchIfGreaterThan },
                { OpCodes.Bge, ShortBranchTargetInstructionType.BranchIfGreaterThanOrEqual },
                { OpCodes.Bge_Un, ShortBranchTargetInstructionType.BranchIfGreaterThanOrEqualUnsigned },
                { OpCodes.Bgt_Un, ShortBranchTargetInstructionType.BranchIfGreaterThanUnsigned },
                { OpCodes.Blt, ShortBranchTargetInstructionType.BranchIfLessThan },
                { OpCodes.Ble, ShortBranchTargetInstructionType.BranchIfLessThanOrEqual },
                { OpCodes.Ble_Un, ShortBranchTargetInstructionType.BranchIfLessThanOrEqualUnsigned },
                { OpCodes.Blt_Un, ShortBranchTargetInstructionType.BranchIfLessThanUnsigned },
                { OpCodes.Bne_Un, ShortBranchTargetInstructionType.BranchIfNotEqual },
                { OpCodes.Brtrue, ShortBranchTargetInstructionType.BranchIfTrue },
                { OpCodes.Leave, ShortBranchTargetInstructionType.Leave }
            };

        private readonly OpCode opCode;
        private readonly ShortBranchTargetInstructionType instructionType;
        private readonly sbyte delta;

        public ShortBranchTargetInstructionWithReflectionEmit(OpCode opCode, sbyte delta)
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
