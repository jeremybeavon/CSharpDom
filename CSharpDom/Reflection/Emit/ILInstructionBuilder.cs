using ClrTest.Reflection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class ILInstructionBuilder : ILInstructionVisitor
    {
        private readonly List<IILInstructionWithReflectionEmit> instructions;
        
        private ILInstructionBuilder(MethodBase method)
        {
            instructions = new List<IILInstructionWithReflectionEmit>();
            new ILReader(method).Accept(this);
        }
        
        public static IReadOnlyList<IILInstructionWithReflectionEmit> GetInstructions(MethodBase method)
        {
            return new ILInstructionBuilder(method).instructions;
        }

        public override void VisitInlineBrTargetInstruction(InlineBrTargetInstruction inlineBrTargetInstruction)
        {
            instructions.Add(new BranchTargetInstructionWithReflectionEmit(inlineBrTargetInstruction.OpCode, inlineBrTargetInstruction.Delta));
        }

        public override void VisitInlineI8Instruction(InlineI8Instruction inlineI8Instruction)
        {
            if (inlineI8Instruction.OpCode != OpCodes.Ldc_I8)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadLongInstructionWithReflectionEmit(inlineI8Instruction.OpCode, inlineI8Instruction.Int64));
        }

        public override void VisitInlineIInstruction(InlineIInstruction inlineIInstruction)
        {
            if (inlineIInstruction.OpCode != OpCodes.Ldc_I4)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadIntegerInstructionWithReflectionEmit(inlineIInstruction.OpCode, inlineIInstruction.Int32));
        }

        public override void VisitInlineNoneInstruction(InlineNoneInstruction inlineNoneInstruction)
        {
            instructions.Add(new SimpleInstructionWithReflectionEmit(inlineNoneInstruction.OpCode));
        }

        public override void VisitInlineRInstruction(InlineRInstruction inlineRInstruction)
        {
            if (inlineRInstruction.OpCode != OpCodes.Ldc_R4)
            {
                throw new NotSupportedException();
            }

            instructions.Add(new LoadDoubleInstructionWithReflectionEmit(inlineRInstruction.OpCode, inlineRInstruction.Double));
        }

        public override void VisitShortInlineBrTargetInstruction(ShortInlineBrTargetInstruction shortInlineBrTargetInstruction)
        {
            instructions.Add(new ShortBranchTargetInstructionWithReflectionEmit(shortInlineBrTargetInstruction.OpCode, shortInlineBrTargetInstruction.Delta));
        }

        public override void VisitShortInlineIInstruction(ShortInlineIInstruction shortInlineIInstruction)
        {
            OpCode opCode = shortInlineIInstruction.OpCode;
            if (opCode == OpCodes.Ldc_I4_S)
            {
                instructions.Add(new LoadByteInstructionWithReflectionEmit(opCode, shortInlineIInstruction.Byte));
            }
            else if (opCode == OpCodes.Unaligned)
            {
                instructions.Add(new UnalignedInstructionWithReflectionEmit(opCode, shortInlineIInstruction.Byte));
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

            instructions.Add(new LoadStringInstructionWithReflectionEmit(opCode, inlineStringInstruction.Token, inlineStringInstruction.String));
        }

        public override void VisitInlineSwitchInstruction(InlineSwitchInstruction inlineSwitchInstruction)
        {
            instructions.Add(new SwitchInstructionWithReflectionEmit(inlineSwitchInstruction.OpCode, inlineSwitchInstruction.Deltas));
        }

        public override void VisitInlineFieldInstruction(InlineFieldInstruction inlineFieldInstruction)
        {
            FieldInstructionWithReflectionEmit instruction = new FieldInstructionWithReflectionEmit(
                inlineFieldInstruction.OpCode,
                inlineFieldInstruction.Token,
                inlineFieldInstruction.Field);
            instructions.Add(instruction);
        }

        public override void VisitInlineMethodInstruction(InlineMethodInstruction inlineMethodInstruction)
        {
            MethodInstructionWithReflectionEmit instruction = new MethodInstructionWithReflectionEmit(
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

            instructions.Add(new LoadMemberTokenInstructionWithReflectionEmit(opCode, inlineTokInstruction.Token, inlineTokInstruction.Member));
        }

        public override void VisitInlineTypeInstruction(InlineTypeInstruction inlineTypeInstruction)
        {
            instructions.Add(new TypeInstructionWithReflectionEmit(inlineTypeInstruction.OpCode, inlineTypeInstruction.Token, inlineTypeInstruction.Type));
        }

        public override void VisitInlineVarInstruction(InlineVarInstruction inlineVarInstruction)
        {
            instructions.Add(new LocalVariableInstructionWithReflectionEmit(inlineVarInstruction.OpCode, inlineVarInstruction.Ordinal));
        }

        public override void VisitShortInlineVarInstruction(ShortInlineVarInstruction shortInlineVarInstruction)
        {
            instructions.Add(new ShortLocalVariableInstructionWithReflectionEmit(shortInlineVarInstruction.OpCode, shortInlineVarInstruction.Ordinal));
        }

        public override void VisitShortInlineRInstruction(ShortInlineRInstruction shortInlineRInstruction)
        {
            instructions.Add(new LoadFloatInstructionWithReflectionEmit(shortInlineRInstruction.OpCode, shortInlineRInstruction.Single));
        }
    }
}
