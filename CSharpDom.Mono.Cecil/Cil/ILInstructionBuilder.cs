using ClrTest.Reflection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class ILInstructionBuilder : ILInstructionVisitor
    {
        private readonly List<IILInstructionWithMonoCecilEmit> instructions;
        
        private ILInstructionBuilder(MethodBase method)
        {
            instructions = new List<IILInstructionWithMonoCecilEmit>();
            new ILReader(method).Accept(this);
        }
        
        public static IReadOnlyList<IILInstructionWithMonoCecilEmit> GetInstructions(MethodBase method)
        {
            return new ILInstructionBuilder(method).instructions;
        }

        public override void VisitInlineBrTargetInstruction(InlineBrTargetInstruction inlineBrTargetInstruction)
        {
            instructions.Add(new BranchTargetInstructionWithMonoCecilEmit(inlineBrTargetInstruction.OpCode, inlineBrTargetInstruction.Delta));
        }

        public override void VisitInlineI8Instruction(InlineI8Instruction inlineI8Instruction)
        {
            if (inlineI8Instruction.OpCode != OpCodes.Ldc_I8)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadLongInstructionWithMonoCecilEmit(inlineI8Instruction.OpCode, inlineI8Instruction.Int64));
        }

        public override void VisitInlineIInstruction(InlineIInstruction inlineIInstruction)
        {
            if (inlineIInstruction.OpCode != OpCodes.Ldc_I4)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadIntegerInstructionWithMonoCecilEmit(inlineIInstruction.OpCode, inlineIInstruction.Int32));
        }

        public override void VisitInlineNoneInstruction(InlineNoneInstruction inlineNoneInstruction)
        {
            instructions.Add(new SimpleInstructionWithMonoCecilEmit(inlineNoneInstruction.OpCode));
        }

        public override void VisitInlineRInstruction(InlineRInstruction inlineRInstruction)
        {
            if (inlineRInstruction.OpCode != OpCodes.Ldc_R4)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadDoubleInstructionWithMonoCecilEmit(inlineRInstruction.OpCode, inlineRInstruction.Double));
        }

        public override void VisitShortInlineBrTargetInstruction(ShortInlineBrTargetInstruction shortInlineBrTargetInstruction)
        {
            instructions.Add(new ShortBranchTargetInstructionWithMonoCecilEmit(shortInlineBrTargetInstruction.OpCode, shortInlineBrTargetInstruction.Delta));
        }

        public override void VisitShortInlineIInstruction(ShortInlineIInstruction shortInlineIInstruction)
        {
            OpCode opCode = shortInlineIInstruction.OpCode;
            if (opCode == OpCodes.Ldc_I4_S)
            {
                instructions.Add(new LoadByteInstructionWithMonoCecilEmit(opCode, shortInlineIInstruction.Byte));
            }
            else if (opCode == OpCodes.Unaligned)
            {
                instructions.Add(new UnalignedInstructionWithMonoCecilEmit(opCode, shortInlineIInstruction.Byte));
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        public override void VisitInlineSigInstruction(InlineSigInstruction inlineSigInstruction)
        {
            throw new NotImplementedException();
        }

        public override void VisitInlineStringInstruction(InlineStringInstruction inlineStringInstruction)
        {
            OpCode opCode = inlineStringInstruction.OpCode;
            if (opCode != OpCodes.Ldc_I8)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadStringInstructionWithMonoCecilEmit(opCode, inlineStringInstruction.Token, inlineStringInstruction.String));
        }

        public override void VisitInlineSwitchInstruction(InlineSwitchInstruction inlineSwitchInstruction)
        {
            instructions.Add(new SwitchInstructionWithMonoCecilEmit(inlineSwitchInstruction.OpCode, inlineSwitchInstruction.Deltas));
        }

        public override void VisitInlineFieldInstruction(InlineFieldInstruction inlineFieldInstruction)
        {
            FieldInstructionWithMonoCecilEmit instruction = new FieldInstructionWithMonoCecilEmit(
                inlineFieldInstruction.OpCode,
                inlineFieldInstruction.Token,
                inlineFieldInstruction.Field);
            instructions.Add(instruction);
        }

        public override void VisitInlineMethodInstruction(InlineMethodInstruction inlineMethodInstruction)
        {
            MethodInstructionWithMonoCecilEmit instruction = new MethodInstructionWithMonoCecilEmit(
                inlineMethodInstruction.OpCode,
                inlineMethodInstruction.Token,
                inlineMethodInstruction.Method);
            instructions.Add(instruction);
        }

        public override void VisitInlineTokInstruction(InlineTokInstruction inlineTokInstruction)
        {
            OpCode opCode = inlineTokInstruction.OpCode;
            if (opCode != OpCodes.Ldtoken)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadMemberTokenInstructionWithMonoCecilEmit(opCode, inlineTokInstruction.Token, inlineTokInstruction.Member));
        }

        public override void VisitInlineTypeInstruction(InlineTypeInstruction inlineTypeInstruction)
        {
            instructions.Add(new TypeInstructionWithMonoCecilEmit(inlineTypeInstruction.OpCode, inlineTypeInstruction.Token, inlineTypeInstruction.Type));
        }

        public override void VisitInlineVarInstruction(InlineVarInstruction inlineVarInstruction)
        {
            instructions.Add(new LocalVariableInstructionWithMonoCecilEmit(inlineVarInstruction.OpCode, inlineVarInstruction.Ordinal));
        }

        public override void VisitShortInlineVarInstruction(ShortInlineVarInstruction shortInlineVarInstruction)
        {
            instructions.Add(new ShortLocalVariableInstructionWithMonoCecilEmit(shortInlineVarInstruction.OpCode, shortInlineVarInstruction.Ordinal));
        }

        public override void VisitShortInlineRInstruction(ShortInlineRInstruction shortInlineRInstruction)
        {
            instructions.Add(new LoadFloatInstructionWithMonoCecilEmit(shortInlineRInstruction.OpCode, shortInlineRInstruction.Single));
        }
    }
}
