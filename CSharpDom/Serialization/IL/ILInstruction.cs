using CSharpDom.Common.IL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace CSharpDom.Serialization.IL
{
    public sealed class ILInstruction : IILInstruction
    {
        [DefaultValue(null)]
        public BranchTargetInstruction BranchTargetInstruction { get; set; }

        [DefaultValue(null)]
        public FieldInstruction FieldInstruction { get; set; }

        [DefaultValue(null)]
        public LoadByteInstruction LoadByteInstruction { get; set; }

        [DefaultValue(null)]
        public LoadDoubleInstruction LoadDoubleInstruction { get; set; }

        [DefaultValue(null)]
        public LoadFloatInstruction LoadFloatInstruction { get; set; }

        [DefaultValue(null)]
        public LoadIntegerInstruction LoadIntegerInstruction { get; set; }

        [DefaultValue(null)]
        public LoadLongInstruction LoadLongInstruction { get; set; }

        [DefaultValue(null)]
        public LoadMemberTokenInstruction LoadMemberTokenInstruction { get; set; }

        [DefaultValue(null)]
        public LoadStringInstruction LoadStringInstruction { get; set; }

        [DefaultValue(null)]
        public LocalVariableInstruction LocalVariableInstruction { get; set; }

        [DefaultValue(null)]
        public MethodInstruction MethodInstruction { get; set; }

        [DefaultValue(null)]
        public ShortBranchTargetInstruction ShortBranchTargetInstruction { get; set; }

        [DefaultValue(null)]
        public ShortLocalVariableInstruction ShortLocalVariableInstruction { get; set; }

        [DefaultValue(null)]
        public SimpleInstruction SimpleInstruction { get; set; }

        [DefaultValue(null)]
        public SwitchInstruction SwitchInstruction { get; set; }

        [DefaultValue(null)]
        public TypeInstruction TypeInstruction { get; set; }

        [DefaultValue(null)]
        public UnalignedInstruction UnalignedInstruction { get; set; }

        private IEnumerable<IILInstruction> Instructions
        {
            get
            {
                yield return BranchTargetInstruction;
                yield return FieldInstruction;
                yield return LoadByteInstruction;
                yield return LoadDoubleInstruction;
                yield return LoadFloatInstruction;
                yield return LoadIntegerInstruction;
                yield return LoadLongInstruction;
                yield return LoadMemberTokenInstruction;
                yield return LoadStringInstruction;
                yield return LocalVariableInstruction;
                yield return MethodInstruction;
                yield return ShortBranchTargetInstruction;
                yield return ShortLocalVariableInstruction;
                yield return SimpleInstruction;
                yield return SwitchInstruction;
                yield return TypeInstruction;
                yield return UnalignedInstruction;
            }
        }

        public void Accept(IILInstructionVisitor visitor)
        {
            IILInstruction instruction = Instructions.FirstOrDefault(current => current != null);
            if (instruction != null)
            {
                instruction.Accept(visitor);
            }
        }

        public void AcceptChildren(IILInstructionVisitor visitor)
        {
        }
    }
}
