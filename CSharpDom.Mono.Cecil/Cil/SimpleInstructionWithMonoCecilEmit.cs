using CSharpDom.BaseClasses.IL;
using CSharpDom.Common.IL;
using Mono.Cecil.Cil;
using System.Collections.Generic;

namespace CSharpDom.Mono.Cecil.Cil
{
    public sealed class SimpleInstructionWithMonoCecilCil : AbstractSimpleInstruction, IILInstructionWithMonoCecilCil
    {
        private static readonly IDictionary<OpCode, SimpleInstructionType> instructionTypes =
            new Dictionary<OpCode, SimpleInstructionType>()
            {
                { OpCodes.Add, SimpleInstructionType.Add },
                { OpCodes.Add_Ovf, SimpleInstructionType.AddWithOverflowCheck },
                { OpCodes.Add_Ovf_Un, SimpleInstructionType.AddUnsignedWithOverflowCheck },
                { OpCodes.Localloc, SimpleInstructionType.AllocateLocalMemory },
                { OpCodes.And, SimpleInstructionType.BitwiseAnd },
                { OpCodes.Arglist, SimpleInstructionType.ArgList },
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
                { OpCodes.Break, SimpleInstructionType.DebuggingBreak },
                { OpCodes.Div, SimpleInstructionType.Divide },
                { OpCodes.Div_Un, SimpleInstructionType.DivideUnsigned },
                { OpCodes.Dup, SimpleInstructionType.DuplicateValue },
                { OpCodes.Endfilter, SimpleInstructionType.EndFilter },
                { OpCodes.Endfinally, SimpleInstructionType.EndFinally },
                { OpCodes.Ceq, SimpleInstructionType.Equal },
                { OpCodes.Cgt, SimpleInstructionType.GreaterThan },
                { OpCodes.Cgt_Un, SimpleInstructionType.GreaterThanUnsigned },
                { OpCodes.Initblk, SimpleInstructionType.InitializeMemoryBlock },
                { OpCodes.Shl, SimpleInstructionType.LeftShift },
                { OpCodes.Clt, SimpleInstructionType.LessThan },
                { OpCodes.Clt_Un, SimpleInstructionType.LessThanUnsigned },
                { OpCodes.Ldarg_0, SimpleInstructionType.LoadArgument0 },
                { OpCodes.Ldarg_1, SimpleInstructionType.LoadArgument1 },
                { OpCodes.Ldarg_2, SimpleInstructionType.LoadArgument2 },
                { OpCodes.Ldarg_3, SimpleInstructionType.LoadArgument3 },
                //{ OpCodes.ld, SimpleInstructionType.LoadArrayLength }, ??
                { OpCodes.Ldelem_I1, SimpleInstructionType.LoadByteArrayElement },
                { OpCodes.Ldind_I1, SimpleInstructionType.LoadByteIndirectly },
                { OpCodes.Ldelem_R8, SimpleInstructionType.LoadDoubleArrayElement },
                { OpCodes.Ldind_R8, SimpleInstructionType.LoadDoubleIndirectly },
                { OpCodes.Ldelem_R4, SimpleInstructionType.LoadFloatArrayElement },
                { OpCodes.Ldind_R4, SimpleInstructionType.LoadFloatIndirectly },
                { OpCodes.Ldc_I4_0, SimpleInstructionType.LoadInteger0 },
                { OpCodes.Ldc_I4_1, SimpleInstructionType.LoadInteger1 },
                { OpCodes.Ldc_I4_2, SimpleInstructionType.LoadInteger2 },
                { OpCodes.Ldc_I4_3, SimpleInstructionType.LoadInteger3 },
                { OpCodes.Ldc_I4_4, SimpleInstructionType.LoadInteger4 },
                { OpCodes.Ldc_I4_5, SimpleInstructionType.LoadInteger5 },
                { OpCodes.Ldc_I4_6, SimpleInstructionType.LoadInteger6 },
                { OpCodes.Ldc_I4_7, SimpleInstructionType.LoadInteger7 },
                { OpCodes.Ldc_I4_8, SimpleInstructionType.LoadInteger8 },
                { OpCodes.Ldelem_I4, SimpleInstructionType.LoadIntegerArrayElement },
                { OpCodes.Ldind_I4, SimpleInstructionType.LoadIntegerIndirectly },
                { OpCodes.Ldc_I4_M1, SimpleInstructionType.LoadIntegerNegative1 },
                { OpCodes.Ldloc_0, SimpleInstructionType.LoadLocalVariable0 },
                { OpCodes.Ldloc_1, SimpleInstructionType.LoadLocalVariable1 },
                { OpCodes.Ldloc_2, SimpleInstructionType.LoadLocalVariable2 },
                { OpCodes.Ldloc_3, SimpleInstructionType.LoadLocalVariable3 },
                { OpCodes.Ldelem_I8, SimpleInstructionType.LoadLongArrayElement },
                { OpCodes.Ldind_I8, SimpleInstructionType.LoadLongIndirectly },
                { OpCodes.Ldelem_I, SimpleInstructionType.LoadNativeIntArrayElement },
                { OpCodes.Ldind_I, SimpleInstructionType.LoadNativeIntegerIndirectly },
                { OpCodes.Ldnull, SimpleInstructionType.LoadNull },
                { OpCodes.Ldelem_Ref, SimpleInstructionType.LoadObjectReferenceArrayElement },
                { OpCodes.Ldind_Ref, SimpleInstructionType.LoadObjectReferenceIndirectly },
                { OpCodes.Ldelem_I2, SimpleInstructionType.LoadShortArrayElement },
                { OpCodes.Ldind_I2, SimpleInstructionType.LoadShortIndirectly },
                { OpCodes.Ldtoken, SimpleInstructionType.LoadType }, //??
                { OpCodes.Ldelem_U1, SimpleInstructionType.LoadUnsignedByteArrayElement },
                { OpCodes.Ldind_U1, SimpleInstructionType.LoadUnsignedByteIndirectly },
                { OpCodes.Ldelem_U4, SimpleInstructionType.LoadUnsignedIntegerArrayElement },
                { OpCodes.Ldind_U4, SimpleInstructionType.LoadUnsignedIntegerIndirectly },
                { OpCodes.Ldelem_U2, SimpleInstructionType.LoadUnsignedShortArrayElement },
                { OpCodes.Ldind_U2, SimpleInstructionType.LoadUnsignedShortIndirectly },
                { OpCodes.Rem, SimpleInstructionType.Modulo },
                { OpCodes.Rem_Un, SimpleInstructionType.ModuloUnsigned },
                { OpCodes.Mul, SimpleInstructionType.Multiply },
                { OpCodes.Mul_Ovf, SimpleInstructionType.MultiplyWithOverflowCheck },
                { OpCodes.Mul_Ovf_Un, SimpleInstructionType.MultiplyUnsignedWithOverflowCheck },
                { OpCodes.Neg, SimpleInstructionType.Negate },
                { OpCodes.Nop, SimpleInstructionType.NoOperation },
                { OpCodes.Pop, SimpleInstructionType.Pop },
                { OpCodes.Readonly, SimpleInstructionType.ReadOnly },
                { OpCodes.Rethrow, SimpleInstructionType.Rethrow },
                { OpCodes.Ret, SimpleInstructionType.Return },
                { OpCodes.Shr, SimpleInstructionType.RightShift },
                { OpCodes.Shr_Un, SimpleInstructionType.RightShiftUnsigned },
                { OpCodes.Stelem_I1, SimpleInstructionType.StoreByteArrayElement },
                { OpCodes.Stind_I1, SimpleInstructionType.StoreByteIndirectly },
                { OpCodes.Stelem_R8, SimpleInstructionType.StoreDoubleArrayElement },
                { OpCodes.Stind_R8, SimpleInstructionType.StoreDoubleIndirectly },
                { OpCodes.Stelem_R4, SimpleInstructionType.StoreFloatArrayElement },
                { OpCodes.Stind_R4, SimpleInstructionType.StoreFloatIndirectly },
                { OpCodes.Stelem_I4, SimpleInstructionType.StoreIntegerArrayElement },
                { OpCodes.Stind_I4, SimpleInstructionType.StoreIntegerIndirectly },
                { OpCodes.Stloc_0, SimpleInstructionType.StoreLocalVariable0 },
                { OpCodes.Stloc_1, SimpleInstructionType.StoreLocalVariable1 },
                { OpCodes.Stloc_2, SimpleInstructionType.StoreLocalVariable2 },
                { OpCodes.Stloc_3, SimpleInstructionType.StoreLocalVariable3 },
                { OpCodes.Stelem_I8, SimpleInstructionType.StoreLongArrayElement },
                { OpCodes.Stind_I8, SimpleInstructionType.StoreLongIndirectly },
                { OpCodes.Stelem_I, SimpleInstructionType.StoreNativeIntegerArrayElement },
                { OpCodes.Stind_I, SimpleInstructionType.StoreNativeIntegerIndirectly },
                { OpCodes.Stelem_Ref, SimpleInstructionType.StoreObjectReferenceArrayElement },
                { OpCodes.Stind_Ref, SimpleInstructionType.StoreObjectReferenceIndirectly },
                { OpCodes.Stelem_I2, SimpleInstructionType.StoreShortArrayElement },
                { OpCodes.Stind_I2, SimpleInstructionType.StoreShortIndirectly },
                { OpCodes.Sub, SimpleInstructionType.Subtract },
                { OpCodes.Sub_Ovf_Un, SimpleInstructionType.SubtractUnsignedWithOverflowCheck },
                { OpCodes.Sub_Ovf, SimpleInstructionType.SubtractWithOverflowCheck },
                { OpCodes.Tail, SimpleInstructionType.TailCall },
                { OpCodes.Throw, SimpleInstructionType.Throw },
                { OpCodes.Volatile, SimpleInstructionType.Volatile },
            };

        private readonly OpCode opCode;
        private readonly SimpleInstructionType instructionType;

        public SimpleInstructionWithMonoCecilCil(OpCode opCode)
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
