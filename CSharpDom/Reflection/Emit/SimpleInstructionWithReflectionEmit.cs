using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CSharpDom.Reflection.Emit
{
    public sealed class SimpleInstructionWithReflectionEmit : AbstractSimpleInstruction, IILInstructionWithReflectionEmit
    {
        private static readonly IDictionary<OpCode, SimpleInstructionType> instructionTypes =
            new Dictionary<OpCode, SimpleInstructionType>()
            {
                { OpCodes.Add, SimpleInstructionType.Add },
                { OpCodes.Add_Ovf, SimpleInstructionType.AddWithOverflowCheck },
                { OpCodes.Add_Ovf_Un, SimpleInstructionType.AddUnsignedWithOverflowCheck },
                { OpCodes.And, SimpleInstructionType.BitwiseAnd },
                { OpCodes.Localloc, SimpleInstructionType.AllocateLocalMemory },
                { OpCodes.Arglist, SimpleInstructionType.BitwiseAnd },
                { OpCodes.Not, SimpleInstructionType.BitwiseNot },
                { OpCodes.Or, SimpleInstructionType.BitwiseOr },
                { OpCodes.Xor, SimpleInstructionType.BitwiseXor },
                { OpCodes.Ckfinite, SimpleInstructionType.CheckFinite },
                { OpCodes.Conv_I, SimpleInstructionType.ConvertValueToNativeInteger },
                { OpCodes.Conv_I1, SimpleInstructionType.ConvertValueToByte },
                { OpCodes.Conv_I2, SimpleInstructionType.ConvertValueToShort },
                { OpCodes.Conv_I4, SimpleInstructionType.ConvertValueToInteger },
                { OpCodes.Conv_I8, SimpleInstructionType.ConvertValueToLong },
                { OpCodes.Conv_Ovf_I, SimpleInstructionType.ConvertSignedValueToNativeIntegerWithOverflowCheck },
                { OpCodes.Conv_Ovf_I1, SimpleInstructionType.ConvertSignedValueToByteWithOverflowCheck },
                { OpCodes.Conv_Ovf_I1_Un, SimpleInstructionType.ConvertUnsignedValueToByteWithOverflowCheck },
                { OpCodes.Conv_Ovf_I2, SimpleInstructionType.ConvertSignedValueToShortWithOverflowCheck },
                { OpCodes.Conv_Ovf_I2_Un, SimpleInstructionType.ConvertUnsignedValueToShortWithOverflowCheck },
                { OpCodes.Conv_Ovf_I4, SimpleInstructionType.ConvertSignedValueToIntegerWithOverflowCheck },
                { OpCodes.Conv_Ovf_I4_Un, SimpleInstructionType.ConvertUnsignedValueToIntegerWithOverflowCheck },
                { OpCodes.Conv_Ovf_I8, SimpleInstructionType.ConvertSignedValueToLongWithOverflowCheck },
                { OpCodes.Conv_Ovf_I8_Un, SimpleInstructionType.ConvertUnsignedValueToLongWithOverflowCheck },
                { OpCodes.Conv_Ovf_I_Un, SimpleInstructionType.ConvertUnsignedValueToNativeIntegerWithOverflowCheck },
                { OpCodes.Conv_Ovf_U, SimpleInstructionType.ConvertSignedValueToNativeIntegerWithOverflowCheck },
                { OpCodes.Conv_Ovf_U1, SimpleInstructionType.ConvertSignedValueToUnsignedByteWithOverflowCheck },
                { OpCodes.Conv_Ovf_U1_Un, SimpleInstructionType.ConvertUnsignedValueToUnsignedByteWithOverflowCheck },
                { OpCodes.Conv_Ovf_U2, SimpleInstructionType.ConvertSignedValueToUnsignedShortWithOverflowCheck },
                { OpCodes.Conv_Ovf_U2_Un, SimpleInstructionType.ConvertUnsignedValueToUnsignedShortWithOverflowCheck },
                { OpCodes.Conv_Ovf_U4, SimpleInstructionType.ConvertSignedValueToUnsignedIntegerWithOverflowCheck },
                { OpCodes.Conv_Ovf_U4_Un, SimpleInstructionType.ConvertUnsignedValueToUnsignedIntegerWithOverflowCheck },
                { OpCodes.Conv_Ovf_U8, SimpleInstructionType.ConvertSignedValueToUnsignedLongWithOverflowCheck },
                { OpCodes.Conv_Ovf_U8_Un, SimpleInstructionType.ConvertUnsignedValueToUnsignedLongWithOverflowCheck },
                { OpCodes.Conv_Ovf_U_Un, SimpleInstructionType.ConvertUnsignedValueToUnsignedNativeIntegerWithOverflowCheck },
                { OpCodes.Conv_R4, SimpleInstructionType.ConvertValueToFloat },
                { OpCodes.Conv_R8, SimpleInstructionType.ConvertValueToDouble },
                { OpCodes.Conv_R_Un, SimpleInstructionType.ConvertUnsignedValueToFloat },
                { OpCodes.Conv_U, SimpleInstructionType.ConvertValueToUnsignedNativeInteger },
                { OpCodes.Conv_U1, SimpleInstructionType.ConvertValueToUnsignedByte },
                { OpCodes.Conv_U2, SimpleInstructionType.ConvertValueToUnsignedShort },
                { OpCodes.Conv_U4, SimpleInstructionType.ConvertValueToUnsignedInteger },
                { OpCodes.Conv_U8, SimpleInstructionType.ConvertValueToUnsignedLong },
                { OpCodes.Cpblk, SimpleInstructionType.CopyMemoryBlock },
                { OpCodes.Div, SimpleInstructionType.Divide },
                { OpCodes.Div_Un, SimpleInstructionType.DivideUnsigned },
                { OpCodes.Dup, SimpleInstructionType.DuplicateValue },
                { OpCodes.Endfilter, SimpleInstructionType.EndFilter },
                { OpCodes.Endfinally, SimpleInstructionType.EndFinally },
                { OpCodes.Initblk, SimpleInstructionType.InitializeMemoryBlock },
                { OpCodes.Break, SimpleInstructionType.DebuggingBreak },
                { OpCodes.Ceq, SimpleInstructionType.Equal },
                { OpCodes.Cgt, SimpleInstructionType.GreaterThan },
                { OpCodes.Cgt_Un, SimpleInstructionType.GreaterThanUnsigned },
                { OpCodes.Shl, SimpleInstructionType.LeftShift },
                { OpCodes.Clt, SimpleInstructionType.LessThan },
                { OpCodes.Clt_Un, SimpleInstructionType.LessThanUnsigned },
                { OpCodes.Ldarg_0, SimpleInstructionType.LoadArgument0 },
                { OpCodes.Ldarg_1, SimpleInstructionType.LoadArgument1 },
                { OpCodes.Ldarg_2, SimpleInstructionType.LoadArgument2 },
                { OpCodes.Ldarg_3, SimpleInstructionType.LoadArgument3 },
                //{ OpCodes.ld, SimpleInstructionType.LoadArrayLength }, ??
                { OpCodes.Ldc_I4_0, SimpleInstructionType.LoadInteger0 },
                { OpCodes.Ldc_I4_1, SimpleInstructionType.LoadInteger1 },
                { OpCodes.Ldc_I4_2, SimpleInstructionType.LoadInteger2 },
                { OpCodes.Ldc_I4_3, SimpleInstructionType.LoadInteger3 },
                { OpCodes.Ldc_I4_4, SimpleInstructionType.LoadInteger4 },
                { OpCodes.Ldc_I4_5, SimpleInstructionType.LoadInteger5 },
                { OpCodes.Ldc_I4_6, SimpleInstructionType.LoadInteger6 },
                { OpCodes.Ldc_I4_7, SimpleInstructionType.LoadInteger7 },
                { OpCodes.Ldc_I4_8, SimpleInstructionType.LoadInteger8 },
                { OpCodes.Ldc_I4_M1, SimpleInstructionType.LoadIntegerNegative1 }
            };

        private readonly OpCode opCode;
        private readonly SimpleInstructionType instructionType;

        public SimpleInstructionWithReflectionEmit(OpCode opCode)
        {
            this.opCode = opCode;
            instructionType = instructionTypes[opCode];
        }

        public override SimpleInstructionType InstructionType
        {
            get { return instructionType; }
        }

        public OpCode OpCode
        {
            get { return opCode; }
        }
    }
}
