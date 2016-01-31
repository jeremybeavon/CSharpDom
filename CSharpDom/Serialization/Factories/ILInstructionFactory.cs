using CSharpDom.Common.IL;
using CSharpDom.Serialization.IL;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Serialization.Factories
{
    public static class ILInstructionFactory
    {
        public static List<ILInstruction> GetInstructions(IEnumerable<IILInstruction> instructions)
        {
            List<ILInstruction> newInstructions = new List<ILInstruction>();
            foreach (IILInstruction instruction in instructions)
            {
                ILInstruction newInstruction =
                    GetBranchTargetInstruction(instruction as IBranchTargetInstruction) ??
                    GetFieldInstruction(instruction as IFieldInstruction) ??
                    GetLoadByteInstruction(instruction as ILoadByteInstruction) ??
                    GetLoadDoubleInstruction(instruction as ILoadDoubleInstruction) ??
                    GetLoadFloatInstruction(instruction as ILoadFloatInstruction) ??
                    GetLoadIntegerInstruction(instruction as ILoadIntegerInstruction) ??
                    GetLoadLongInstruction(instruction as ILoadLongInstruction) ??
                    GetLoadMemberTokenInstruction(instruction as ILoadMemberTokenInstruction) ??
                    GetLoadStringInstruction(instruction as ILoadStringInstruction) ??
                    GetLocalVariableInstruction(instruction as ILocalVariableInstruction) ??
                    GetMethodInstruction(instruction as IMethodInstruction) ??
                    GetShortBranchTargetInstruction(instruction as IShortBranchTargetInstruction) ??
                    GetShortLocalVariableInstruction(instruction as IShortLocalVariableInstruction) ??
                    GetSimpleInstruction(instruction as ISimpleInstruction) ??
                    GetSwitchInstruction(instruction as ISwitchInstruction) ??
                    GetTypeInstruction(instruction as ITypeInstruction) ??
                    GetUnalignedInstruction(instruction as IUnalignedInstruction);
                newInstructions.Add(newInstruction);
            }

            return newInstructions;
        }

        public static ILInstruction GetBranchTargetInstruction(IBranchTargetInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    BranchTargetInstruction = new BranchTargetInstruction()
                    {
                        Delta = instruction.Delta,
                        InstructionType = instruction.InstructionType
                    }
                };
        }

        public static ILInstruction GetFieldInstruction(IFieldInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    FieldInstruction = new FieldInstruction()
                    {
                        InstructionType = instruction.InstructionType,
                        Token = instruction.Token
                    }
                };
        }

        public static ILInstruction GetLoadByteInstruction(ILoadByteInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LoadByteInstruction = new LoadByteInstruction()
                    {
                        Value = instruction.Value
                    }
                };
        }

        public static ILInstruction GetLoadDoubleInstruction(ILoadDoubleInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LoadDoubleInstruction = new LoadDoubleInstruction()
                    {
                        Value = instruction.Value
                    }
                };
        }

        public static ILInstruction GetLoadFloatInstruction(ILoadFloatInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LoadFloatInstruction = new LoadFloatInstruction()
                    {
                        Value = instruction.Value
                    }
                };
        }

        public static ILInstruction GetLoadIntegerInstruction(ILoadIntegerInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LoadIntegerInstruction = new LoadIntegerInstruction()
                    {
                        Value = instruction.Value
                    }
                };
        }

        public static ILInstruction GetLoadLongInstruction(ILoadLongInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LoadLongInstruction = new LoadLongInstruction()
                    {
                        Value = instruction.Value
                    }
                };
        }

        public static ILInstruction GetLoadMemberTokenInstruction(ILoadMemberTokenInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LoadMemberTokenInstruction = new LoadMemberTokenInstruction()
                    {
                        Token = instruction.Token
                    }
                };
        }

        public static ILInstruction GetLoadStringInstruction(ILoadStringInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LoadStringInstruction = new LoadStringInstruction()
                    {
                        Value = instruction.Value
                    }
                };
        }

        public static ILInstruction GetLocalVariableInstruction(ILocalVariableInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    LocalVariableInstruction = new LocalVariableInstruction()
                    {
                        InstructionType = instruction.InstructionType,
                        Ordinal = instruction.Ordinal
                    }
                };
        }

        public static ILInstruction GetMethodInstruction(IMethodInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    MethodInstruction = new MethodInstruction()
                    {
                        InstructionType = instruction.InstructionType,
                        Token = instruction.Token
                    }
                };
        }

        public static ILInstruction GetShortBranchTargetInstruction(IShortBranchTargetInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    ShortBranchTargetInstruction = new ShortBranchTargetInstruction()
                    {
                        Delta = instruction.Delta,
                        InstructionType = instruction.InstructionType
                    }
                };
        }

        public static ILInstruction GetShortLocalVariableInstruction(IShortLocalVariableInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    ShortLocalVariableInstruction = new ShortLocalVariableInstruction()
                    {
                        InstructionType = instruction.InstructionType,
                        Ordinal = instruction.Ordinal
                    }
                };
        }

        public static ILInstruction GetSimpleInstruction(ISimpleInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    SimpleInstruction = new SimpleInstruction()
                    {
                        InstructionType = instruction.InstructionType
                    }
                };
        }

        public static ILInstruction GetSwitchInstruction(ISwitchInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    SwitchInstruction = new SwitchInstruction()
                    {
                        Deltas = instruction.Deltas.ToList()
                    }
                };
        }

        public static ILInstruction GetTypeInstruction(ITypeInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    TypeInstruction = new TypeInstruction()
                    {
                        InstructionType = instruction.InstructionType,
                        Token = instruction.Token
                    }
                };
        }

        public static ILInstruction GetUnalignedInstruction(IUnalignedInstruction instruction)
        {
            return instruction == null ? null :
                new ILInstruction()
                {
                    UnalignedInstruction = new UnalignedInstruction()
                    {
                        Value = instruction.Value
                    }
                };
        }
    }
}
