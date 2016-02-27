using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class BranchTargetInstructionWithMonoCecilEmit : AbstractBranchTargetInstruction, IILInstructionWithMonoCecilEmit
    {
        private static readonly IDictionary<OpCode, BranchTargetInstructionType> instructionTypes =
            new Dictionary<OpCode, BranchTargetInstructionType>()
            {
                { OpCodes.Br, BranchTargetInstructionType.Branch },
                { OpCodes.Beq, BranchTargetInstructionType.BranchIfEqual },
                { OpCodes.Brfalse, BranchTargetInstructionType.BranchIfFalse },
                { OpCodes.Bgt, BranchTargetInstructionType.BranchIfGreaterThan },
                { OpCodes.Bge, BranchTargetInstructionType.BranchIfGreaterThanOrEqual },
                { OpCodes.Bge_Un, BranchTargetInstructionType.BranchIfGreaterThanOrEqualUnsigned },
                { OpCodes.Bgt_Un, BranchTargetInstructionType.BranchIfGreaterThanUnsigned },
                { OpCodes.Blt, BranchTargetInstructionType.BranchIfLessThan },
                { OpCodes.Ble, BranchTargetInstructionType.BranchIfLessThanOrEqual },
                { OpCodes.Ble_Un, BranchTargetInstructionType.BranchIfLessThanOrEqualUnsigned },
                { OpCodes.Blt_Un, BranchTargetInstructionType.BranchIfLessThanUnsigned },
                { OpCodes.Bne_Un, BranchTargetInstructionType.BranchIfNotEqual },
                { OpCodes.Brtrue, BranchTargetInstructionType.BranchIfTrue },
                { OpCodes.Leave, BranchTargetInstructionType.Leave }
            };

        private readonly OpCode opCode;
        private readonly BranchTargetInstructionType instructionType;
        private readonly int delta;

        public BranchTargetInstructionWithMonoCecilEmit(OpCode opCode, int delta)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
            this.delta = delta;
        }

        public override int Delta
        {
            get { return delta; }
        }

        public override BranchTargetInstructionType InstructionType
        {
            get { return instructionType; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }
    }
}
