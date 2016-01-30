using System;
using System.Collections.Generic;

namespace CSharpDom.Common.IL
{
    public static class ILInstructionVisitor
    {
        private delegate Action<IBranchTargetInstruction> VisitBranchTargetInstructionFunc(IILInstructionVisitor visitor);
        private delegate Action<IFieldInstruction> VisitFieldInstructionFunc(IILInstructionVisitor visitor);
        private delegate Action<ILocalVariableInstruction> VisitLocalVariableInstructionFunc(IILInstructionVisitor visitor);
        private delegate Action<IMethodInstruction> VisitMethodInstructionFunc(IILInstructionVisitor visitor);
        private delegate Action<IShortBranchTargetInstruction> VisitShortBranchTargetInstructionFunc(IILInstructionVisitor visitor);
        private delegate Action<IShortLocalVariableInstruction> VisitShortLocalVariableInstructionFunc(IILInstructionVisitor visitor);
        private delegate Action<ISimpleInstruction> VisitSimpleInstructionFunc(IILInstructionVisitor visitor);
        private delegate Action<ITypeInstruction> VisitTypeInstructionFunc(IILInstructionVisitor visitor);

        private static readonly IDictionary<BranchTargetInstructionType, VisitBranchTargetInstructionFunc> branchTargetInstructionVisitor =
            new Dictionary<BranchTargetInstructionType, VisitBranchTargetInstructionFunc>()
            {
                { BranchTargetInstructionType.BranchIfEqual, visitor => visitor.VisitBranchIfEqualInstruction },
                { BranchTargetInstructionType.BranchIfGreaterThanOrEqual, visitor => visitor.VisitBranchIfGreaterThanOrEqualInstruction },
                { BranchTargetInstructionType.BranchIfGreaterThanOrEqualUnsigned, visitor => visitor.VisitBranchIfGreaterThanOrEqualUnsignedInstruction },
                { BranchTargetInstructionType.BranchIfGreaterThan, visitor => visitor.VisitBranchIfGreaterThanInstruction },
                { BranchTargetInstructionType.BranchIfGreaterThanUnsigned, visitor => visitor.VisitBranchIfGreaterThanUnsignedInstruction },
                { BranchTargetInstructionType.BranchIfLessThanOrEqual, visitor => visitor.VisitBranchIfLessThanOrEqualInstruction },
                { BranchTargetInstructionType.BranchIfLessThanOrEqualUnsigned, visitor => visitor.VisitBranchIfLessThanOrEqualUnsignedInstruction },
                { BranchTargetInstructionType.BranchIfLessThan, visitor => visitor.VisitBranchIfLessThanInstruction },
                { BranchTargetInstructionType.BranchIfLessThanUnsigned, visitor => visitor.VisitBranchIfLessThanUnsignedInstruction },
                { BranchTargetInstructionType.BranchIfNotEqual, visitor => visitor.VisitBranchIfNotEqualInstruction },
                { BranchTargetInstructionType.Branch, visitor => visitor.VisitBranchInstruction },
                { BranchTargetInstructionType.BranchIfFalse, visitor => visitor.VisitBranchIfFalseInstruction },
                { BranchTargetInstructionType.BranchIfTrue, visitor => visitor.VisitBranchIfTrueInstruction },
                { BranchTargetInstructionType.Leave, visitor => visitor.VisitLeaveInstruction }
            };

        private static readonly IDictionary<FieldInstructionType, VisitFieldInstructionFunc> fieldInstructionVisitor =
            new Dictionary<FieldInstructionType, VisitFieldInstructionFunc>()
            {
                { FieldInstructionType.LoadField, visitor => visitor.VisitLoadFieldInstruction },
                { FieldInstructionType.LoadFieldAddress, visitor => visitor.VisitLoadFieldAddressInstruction },
                { FieldInstructionType.LoadStaticField, visitor => visitor.VisitLoadStaticFieldInstruction },
                { FieldInstructionType.LoadStaticFieldAddress, visitor => visitor.VisitLoadStaticFieldAddressInstruction },
                { FieldInstructionType.StoreField, visitor => visitor.VisitStoreFieldInstruction },
                { FieldInstructionType.StoreStaticField, visitor => visitor.VisitStoreStaticFieldInstruction }
            };

        private static readonly IDictionary<LocalVariableInstructionType, VisitLocalVariableInstructionFunc> localVariableInstructionVisitor =
            new Dictionary<LocalVariableInstructionType, VisitLocalVariableInstructionFunc>()
            {
                { LocalVariableInstructionType.LoadArgument, visitor => visitor.VisitLoadArgumentInstruction },
                { LocalVariableInstructionType.LoadArgumentAddress, visitor => visitor.VisitLoadArgumentAddressInstruction },
                { LocalVariableInstructionType.LoadLocalVariable, visitor => visitor.VisitLoadLocalVariableInstruction },
                { LocalVariableInstructionType.LoadLocalVariableAddress, visitor => visitor.VisitLoadLocalVariableAddressInstruction },
                { LocalVariableInstructionType.StoreArgument, visitor => visitor.VisitStoreArgumentInstruction },
                { LocalVariableInstructionType.StoreLocalVariable, visitor => visitor.VisitStoreLocalVariableInstruction }
            };

        private static readonly IDictionary<MethodInstructionType, VisitMethodInstructionFunc> methodInstructionVisitor =
            new Dictionary<MethodInstructionType, VisitMethodInstructionFunc>()
            {
                { MethodInstructionType.CallMethod, visitor => visitor.VisitCallMethodInstruction },
                { MethodInstructionType.CallVirtualMethod, visitor => visitor.VisitCallVirtualMethodInstruction },
                { MethodInstructionType.Jump, visitor => visitor.VisitJumpInstruction },
                { MethodInstructionType.LoadPointer, visitor => visitor.VisitLoadPointerInstruction },
                { MethodInstructionType.LoadVirtualPointer, visitor => visitor.VisitLoadVirtualPointerInstruction },
                { MethodInstructionType.NewObject, visitor => visitor.VisitNewObjectInstruction }
            };

        private static readonly IDictionary<ShortBranchTargetInstructionType, VisitShortBranchTargetInstructionFunc> shortBranchTargetInstructionVisitor =
            new Dictionary<ShortBranchTargetInstructionType, VisitShortBranchTargetInstructionFunc>()
            {
                { ShortBranchTargetInstructionType.BranchIfEqual, visitor => visitor.VisitBranchIfEqualInstruction },
                { ShortBranchTargetInstructionType.BranchIfGreaterThanOrEqual, visitor => visitor.VisitBranchIfGreaterThanOrEqualInstruction },
                { ShortBranchTargetInstructionType.BranchIfGreaterThanOrEqualUnsigned, visitor => visitor.VisitBranchIfGreaterThanOrEqualUnsignedInstruction },
                { ShortBranchTargetInstructionType.BranchIfGreaterThan, visitor => visitor.VisitBranchIfGreaterThanInstruction },
                { ShortBranchTargetInstructionType.BranchIfGreaterThanUnsigned, visitor => visitor.VisitBranchIfGreaterThanUnsignedInstruction },
                { ShortBranchTargetInstructionType.BranchIfLessThanOrEqual, visitor => visitor.VisitBranchIfLessThanOrEqualInstruction },
                { ShortBranchTargetInstructionType.BranchIfLessThanOrEqualUnsigned, visitor => visitor.VisitBranchIfLessThanOrEqualUnsignedInstruction },
                { ShortBranchTargetInstructionType.BranchIfLessThan, visitor => visitor.VisitBranchIfLessThanInstruction },
                { ShortBranchTargetInstructionType.BranchIfLessThanUnsigned, visitor => visitor.VisitBranchIfLessThanUnsignedInstruction },
                { ShortBranchTargetInstructionType.BranchIfNotEqual, visitor => visitor.VisitBranchIfNotEqualInstruction },
                { ShortBranchTargetInstructionType.Branch, visitor => visitor.VisitBranchInstruction },
                { ShortBranchTargetInstructionType.BranchIfFalse, visitor => visitor.VisitBranchIfFalseInstruction },
                { ShortBranchTargetInstructionType.BranchIfTrue, visitor => visitor.VisitBranchIfTrueInstruction },
                { ShortBranchTargetInstructionType.Leave, visitor => visitor.VisitLeaveInstruction }
            };

        private static readonly IDictionary<ShortLocalVariableInstructionType, VisitShortLocalVariableInstructionFunc> shortLocalVariableInstructionVisitor =
            new Dictionary<ShortLocalVariableInstructionType, VisitShortLocalVariableInstructionFunc>()
            {
                { ShortLocalVariableInstructionType.LoadArgument, visitor => visitor.VisitLoadArgumentInstruction },
                { ShortLocalVariableInstructionType.LoadArgumentAddress, visitor => visitor.VisitLoadArgumentAddressInstruction },
                { ShortLocalVariableInstructionType.LoadLocalVariable, visitor => visitor.VisitLoadLocalVariableInstruction },
                { ShortLocalVariableInstructionType.LoadLocalVariableAddress, visitor => visitor.VisitLoadLocalVariableAddressInstruction },
                { ShortLocalVariableInstructionType.StoreArgument, visitor => visitor.VisitStoreArgumentInstruction },
                { ShortLocalVariableInstructionType.StoreLocalVariable, visitor => visitor.VisitStoreLocalVariableInstruction }
            };

        private static readonly IDictionary<SimpleInstructionType, VisitSimpleInstructionFunc> simpleInstructionVisitor =
            new Dictionary<SimpleInstructionType, VisitSimpleInstructionFunc>()
            {
                { SimpleInstructionType.Add, visitor => visitor.VisitAddInstruction },
                { SimpleInstructionType.AddWithOverflowCheck, visitor => visitor.VisitAddWithOverflowCheckInstruction },
                { SimpleInstructionType.AddUnsignedWithOverflowCheck, visitor => visitor.VisitAddUnsignedWithOverflowCheckInstruction },
                { SimpleInstructionType.BitwiseAnd, visitor => visitor.VisitBitwiseAndInstruction },
                { SimpleInstructionType.ArgList, visitor => visitor.VisitArgListInstruction },
                { SimpleInstructionType.DebuggingBreak, visitor => visitor.VisitDebuggingBreakInstruction },
                { SimpleInstructionType.Equal, visitor => visitor.VisitEqualInstruction },
                { SimpleInstructionType.GreaterThan, visitor => visitor.VisitGreaterThanInstruction },
                { SimpleInstructionType.GreaterThanUnsigned, visitor => visitor.VisitGreaterThanUnsignedInstruction },
                { SimpleInstructionType.CheckFinite, visitor => visitor.VisitCheckFiniteInstruction },
                { SimpleInstructionType.LessThan, visitor => visitor.VisitLessThanInstruction },
                { SimpleInstructionType.LessThanUnsigned, visitor => visitor.VisitLessThanUnsignedInstruction },
                { SimpleInstructionType.ConvertValueToNativeInteger, visitor => visitor.VisitConvertValueToNativeIntegerInstruction },
                { SimpleInstructionType.ConvertValueToByte, visitor => visitor.VisitConvertValueToByteInstruction },
                { SimpleInstructionType.ConvertValueToShort, visitor => visitor.VisitConvertValueToShortInstruction },
                { SimpleInstructionType.ConvertValueToInteger, visitor => visitor.VisitConvertValueToIntegerInstruction },
                { SimpleInstructionType.ConvertValueToLong, visitor => visitor.VisitConvertValueToLongInstruction },
                { SimpleInstructionType.ConvertSignedValueToNativeIntegerWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToNativeIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToNativeIntegerWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToNativeIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToByteWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToByteWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToByteWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToByteWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToShortWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToShortWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToShortWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToShortWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToIntegerWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToIntegerWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToLongWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToLongWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToLongWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToLongWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToUnsignedNativeIntegerWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToUnsignedNativeIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToUnsignedNativeIntegerWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToUnsignedNativeIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToUnsignedByteWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToUnsignedByteWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToUnsignedByteWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToUnsignedByteWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToUnsignedShortWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToUnsignedShortWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToUnsignedShortWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToUnsignedShortWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToUnsignedIntegerWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToUnsignedIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToUnsignedIntegerWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToUnsignedIntegerWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertSignedValueToUnsignedLongWithOverflowCheck, visitor => visitor.VisitConvertSignedValueToUnsignedLongWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToUnsignedLongWithOverflowCheck, visitor => visitor.VisitConvertUnsignedValueToUnsignedLongWithOverflowCheckInstruction },
                { SimpleInstructionType.ConvertUnsignedValueToFloat, visitor => visitor.VisitConvertUnsignedValueToFloatInstruction },
                { SimpleInstructionType.ConvertValueToFloat, visitor => visitor.VisitConvertValueToFloatInstruction },
                { SimpleInstructionType.ConvertValueToDouble, visitor => visitor.VisitConvertValueToDoubleInstruction },
                { SimpleInstructionType.ConvertValueToUnsignedNativeInteger, visitor => visitor.VisitConvertValueToUnsignedNativeIntegerInstruction },
                { SimpleInstructionType.ConvertValueToUnsignedByte, visitor => visitor.VisitConvertValueToUnsignedByteInstruction },
                { SimpleInstructionType.ConvertValueToUnsignedShort, visitor => visitor.VisitConvertValueToUnsignedShortInstruction },
                { SimpleInstructionType.ConvertValueToUnsignedInteger, visitor => visitor.VisitConvertValueToUnsignedIntegerInstruction },
                { SimpleInstructionType.ConvertValueToUnsignedLong, visitor => visitor.VisitConvertValueToUnsignedLongInstruction },
                { SimpleInstructionType.CopyMemoryBlock, visitor => visitor.VisitCopyMemoryBlockInstruction },
                { SimpleInstructionType.Divide, visitor => visitor.VisitDivideInstruction },
                { SimpleInstructionType.DivideUnsigned, visitor => visitor.VisitDivideUnsignedInstruction },
                { SimpleInstructionType.DuplicateValue, visitor => visitor.VisitDuplicateValueInstruction },
                { SimpleInstructionType.EndFilter, visitor => visitor.VisitEndFilterInstruction },
                { SimpleInstructionType.EndFinally, visitor => visitor.VisitEndFinallyInstruction },
                { SimpleInstructionType.InitializeMemoryBlock, visitor => visitor.VisitInitializeMemoryBlockInstruction },
                { SimpleInstructionType.LoadArgument0, visitor => visitor.VisitLoadArgument0Instruction },
                { SimpleInstructionType.LoadArgument1, visitor => visitor.VisitLoadArgument1Instruction },
                { SimpleInstructionType.LoadArgument2, visitor => visitor.VisitLoadArgument2Instruction },
                { SimpleInstructionType.LoadArgument3, visitor => visitor.VisitLoadArgument3Instruction },
                { SimpleInstructionType.LoadInteger0, visitor => visitor.VisitLoadInteger0Instruction },
                { SimpleInstructionType.LoadInteger1, visitor => visitor.VisitLoadInteger1Instruction },
                { SimpleInstructionType.LoadInteger2, visitor => visitor.VisitLoadInteger2Instruction },
                { SimpleInstructionType.LoadInteger3, visitor => visitor.VisitLoadInteger3Instruction },
                { SimpleInstructionType.LoadInteger4, visitor => visitor.VisitLoadInteger4Instruction },
                { SimpleInstructionType.LoadInteger5, visitor => visitor.VisitLoadInteger5Instruction },
                { SimpleInstructionType.LoadInteger6, visitor => visitor.VisitLoadInteger6Instruction },
                { SimpleInstructionType.LoadInteger7, visitor => visitor.VisitLoadInteger7Instruction },
                { SimpleInstructionType.LoadInteger8, visitor => visitor.VisitLoadInteger8Instruction },
                { SimpleInstructionType.LoadIntegerNegative1, visitor => visitor.VisitLoadIntegerNegative1Instruction },
                { SimpleInstructionType.LoadNativeIntArrayElement, visitor => visitor.VisitLoadNativeIntArrayElementInstruction },
                { SimpleInstructionType.LoadByteArrayElement, visitor => visitor.VisitLoadByteArrayElementInstruction },
                { SimpleInstructionType.LoadShortArrayElement, visitor => visitor.VisitLoadShortArrayElementInstruction },
                { SimpleInstructionType.LoadIntegerArrayElement, visitor => visitor.VisitLoadIntegerArrayElementInstruction },
                { SimpleInstructionType.LoadLongArrayElement, visitor => visitor.VisitLoadLongArrayElementInstruction },
                { SimpleInstructionType.LoadFloatArrayElement, visitor => visitor.VisitLoadFloatArrayElementInstruction },
                { SimpleInstructionType.LoadDoubleArrayElement, visitor => visitor.VisitLoadDoubleArrayElementInstruction },
                { SimpleInstructionType.LoadObjectReferenceArrayElement, visitor => visitor.VisitLoadObjectReferenceArrayElementInstruction },
                { SimpleInstructionType.LoadUnsignedByteArrayElement, visitor => visitor.VisitLoadUnsignedByteArrayElementInstruction },
                { SimpleInstructionType.LoadUnsignedShortArrayElement, visitor => visitor.VisitLoadUnsignedShortArrayElementInstruction },
                { SimpleInstructionType.LoadUnsignedIntegerArrayElement, visitor => visitor.VisitLoadUnsignedIntegerArrayElementInstruction },
                { SimpleInstructionType.LoadNativeIntegerIndirectly, visitor => visitor.VisitLoadNativeIntegerIndirectlyInstruction },
                { SimpleInstructionType.LoadByteIndirectly, visitor => visitor.VisitLoadByteIndirectlyInstruction },
                { SimpleInstructionType.LoadShortIndirectly, visitor => visitor.VisitLoadShortIndirectlyInstruction },
                { SimpleInstructionType.LoadIntegerIndirectly, visitor => visitor.VisitLoadIntegerIndirectlyInstruction },
                { SimpleInstructionType.LoadLongIndirectly, visitor => visitor.VisitLoadLongIndirectlyInstruction },
                { SimpleInstructionType.LoadFloatIndirectly, visitor => visitor.VisitLoadFloatIndirectlyInstruction },
                { SimpleInstructionType.LoadDoubleIndirectly, visitor => visitor.VisitLoadDoubleIndirectlyInstruction },
                { SimpleInstructionType.LoadObjectReferenceIndirectly, visitor => visitor.VisitLoadObjectReferenceIndirectlyInstruction },
                { SimpleInstructionType.LoadUnsignedByteIndirectly, visitor => visitor.VisitLoadUnsignedByteIndirectlyInstruction },
                { SimpleInstructionType.LoadUnsignedShortIndirectly, visitor => visitor.VisitLoadUnsignedShortIndirectlyInstruction },
                { SimpleInstructionType.LoadUnsignedIntegerIndirectly, visitor => visitor.VisitLoadUnsignedIntegerIndirectlyInstruction },
                { SimpleInstructionType.LoadArrayLength, visitor => visitor.VisitLoadArrayLengthInstruction },
                { SimpleInstructionType.LoadLocalVariable0, visitor => visitor.VisitLoadLocalVariable0Instruction },
                { SimpleInstructionType.LoadLocalVariable1, visitor => visitor.VisitLoadLocalVariable1Instruction },
                { SimpleInstructionType.LoadLocalVariable2, visitor => visitor.VisitLoadLocalVariable2Instruction },
                { SimpleInstructionType.LoadLocalVariable3, visitor => visitor.VisitLoadLocalVariable3Instruction },
                { SimpleInstructionType.LoadNull, visitor => visitor.VisitLoadNullInstruction },
                { SimpleInstructionType.AllocateLocalMemory, visitor => visitor.VisitAllocateLocalMemoryInstruction },
                { SimpleInstructionType.Multiply, visitor => visitor.VisitMultiplyInstruction },
                { SimpleInstructionType.MultiplyWithOverflowCheck, visitor => visitor.VisitMultiplyWithOverflowCheckInstruction },
                { SimpleInstructionType.MultiplyUnsignedWithOverflowCheck, visitor => visitor.VisitMultiplyUnsignedWithOverflowCheckInstruction },
                { SimpleInstructionType.Negate, visitor => visitor.VisitNegateInstruction },
                { SimpleInstructionType.NoOperation, visitor => visitor.VisitNoOperationInstruction },
                { SimpleInstructionType.BitwiseNot, visitor => visitor.VisitBitwiseNotInstruction },
                { SimpleInstructionType.BitwiseOr, visitor => visitor.VisitBitwiseOrInstruction },
                { SimpleInstructionType.Pop, visitor => visitor.VisitPopInstruction },
                { SimpleInstructionType.ReadOnly, visitor => visitor.VisitReadOnlyInstruction },
                { SimpleInstructionType.LoadType, visitor => visitor.VisitLoadTypeInstruction },
                { SimpleInstructionType.Modulo, visitor => visitor.VisitModuloInstruction },
                { SimpleInstructionType.ModuloUnsigned, visitor => visitor.VisitModuloUnsignedInstruction },
                { SimpleInstructionType.Return, visitor => visitor.VisitReturnInstruction },
                { SimpleInstructionType.Rethrow, visitor => visitor.VisitRethrowInstruction },
                { SimpleInstructionType.LeftShift, visitor => visitor.VisitLeftShiftInstruction },
                { SimpleInstructionType.RightShift, visitor => visitor.VisitRightShiftInstruction },
                { SimpleInstructionType.RightShiftUnsigned, visitor => visitor.VisitRightShiftUnsignedInstruction },
                { SimpleInstructionType.StoreNativeIntegerArrayElement, visitor => visitor.VisitStoreNativeIntegerArrayElementInstruction },
                { SimpleInstructionType.StoreByteArrayElement, visitor => visitor.VisitStoreByteArrayElementInstruction },
                { SimpleInstructionType.StoreShortArrayElement, visitor => visitor.VisitStoreShortArrayElementInstruction },
                { SimpleInstructionType.StoreIntegerArrayElement, visitor => visitor.VisitStoreIntegerArrayElementInstruction },
                { SimpleInstructionType.StoreLongArrayElement, visitor => visitor.VisitStoreLongArrayElementInstruction },
                { SimpleInstructionType.StoreFloatArrayElement, visitor => visitor.VisitStoreFloatArrayElementInstruction },
                { SimpleInstructionType.StoreDoubleArrayElement, visitor => visitor.VisitStoreDoubleArrayElementInstruction },
                { SimpleInstructionType.StoreObjectReferenceArrayElement, visitor => visitor.VisitStoreObjectReferenceArrayElementInstruction },
                { SimpleInstructionType.StoreNativeIntegerIndirectly, visitor => visitor.VisitStoreNativeIntegerIndirectlyInstruction },
                { SimpleInstructionType.StoreByteIndirectly, visitor => visitor.VisitStoreByteIndirectlyInstruction },
                { SimpleInstructionType.StoreShortIndirectly, visitor => visitor.VisitStoreShortIndirectlyInstruction },
                { SimpleInstructionType.StoreIntegerIndirectly, visitor => visitor.VisitStoreIntegerIndirectlyInstruction },
                { SimpleInstructionType.StoreLongIndirectly, visitor => visitor.VisitStoreLongIndirectlyInstruction },
                { SimpleInstructionType.StoreFloatIndirectly, visitor => visitor.VisitStoreFloatIndirectlyInstruction },
                { SimpleInstructionType.StoreDoubleIndirectly, visitor => visitor.VisitStoreDoubleIndirectlyInstruction },
                { SimpleInstructionType.StoreObjectReferenceIndirectly, visitor => visitor.VisitStoreObjectReferenceIndirectlyInstruction },
                { SimpleInstructionType.StoreLocalVariable0, visitor => visitor.VisitStoreLocalVariable0Instruction },
                { SimpleInstructionType.StoreLocalVariable1, visitor => visitor.VisitStoreLocalVariable1Instruction },
                { SimpleInstructionType.StoreLocalVariable2, visitor => visitor.VisitStoreLocalVariable2Instruction },
                { SimpleInstructionType.StoreLocalVariable3, visitor => visitor.VisitStoreLocalVariable3Instruction },
                { SimpleInstructionType.Subtract, visitor => visitor.VisitSubtractInstruction },
                { SimpleInstructionType.SubtractWithOverflowCheck, visitor => visitor.VisitSubtractWithOverflowCheckInstruction },
                { SimpleInstructionType.SubtractUnsignedWithOverflowCheck, visitor => visitor.VisitSubtractUnsignedWithOverflowCheckInstruction },
                { SimpleInstructionType.TailCall, visitor => visitor.VisitTailCallInstruction },
                { SimpleInstructionType.Throw, visitor => visitor.VisitThrowInstruction },
                { SimpleInstructionType.Volatile, visitor => visitor.VisitVolatileInstruction },
                { SimpleInstructionType.BitwiseXor, visitor => visitor.VisitBitwiseXorInstruction }
            };

        private static readonly IDictionary<TypeInstructionType, VisitTypeInstructionFunc> typeInstructionVisitor =
            new Dictionary<TypeInstructionType, VisitTypeInstructionFunc>()
            {
                { TypeInstructionType.Box, visitor => visitor.VisitBoxInstruction },
                { TypeInstructionType.Cast, visitor => visitor.VisitCastInstruction },
                { TypeInstructionType.Constrained, visitor => visitor.VisitConstrainedInstruction },
                { TypeInstructionType.CopyObject, visitor => visitor.VisitCopyObjectInstruction },
                { TypeInstructionType.InitializeObject, visitor => visitor.VisitInitializeObjectInstruction },
                { TypeInstructionType.IsInstanceOfClass, visitor => visitor.VisitIsInstanceOfClassInstruction },
                { TypeInstructionType.LoadArrayElement, visitor => visitor.VisitLoadArrayElementInstruction },
                { TypeInstructionType.LoadArrayElementAddress, visitor => visitor.VisitLoadArrayElementAddressInstruction },
                { TypeInstructionType.LoadObject, visitor => visitor.VisitLoadObjectInstruction },
                { TypeInstructionType.LoadTypeReference, visitor => visitor.VisitLoadTypeReferenceInstruction },
                { TypeInstructionType.NewArray, visitor => visitor.VisitNewArrayInstruction },
                { TypeInstructionType.LoadAddress, visitor => visitor.VisitLoadAddressInstruction },
                { TypeInstructionType.SizeOf, visitor => visitor.VisitSizeOfInstruction },
                { TypeInstructionType.StoreArrayElement, visitor => visitor.VisitStoreArrayElementInstruction },
                { TypeInstructionType.StoreObject, visitor => visitor.VisitStoreObjectInstruction },
                { TypeInstructionType.Unbox, visitor => visitor.VisitUnboxInstruction },
                { TypeInstructionType.UnboxAny, visitor => visitor.VisitUnboxAnyInstruction }
            };

        public static void VisitBranchTargetInstruction(
            IBranchTargetInstruction branchTargetInstruction,
            IILInstructionVisitor visitor)
        {
            branchTargetInstructionVisitor[branchTargetInstruction.InstructionType](visitor)(branchTargetInstruction);
        }

        public static void VisitFieldInstruction(IFieldInstruction fieldInstruction, IILInstructionVisitor visitor)
        {
            fieldInstructionVisitor[fieldInstruction.InstructionType](visitor)(fieldInstruction);
        }

        public static void VisitLocalVariableInstruction(
            ILocalVariableInstruction localVariableInstruction,
            IILInstructionVisitor visitor)
        {
            localVariableInstructionVisitor[localVariableInstruction.InstructionType](visitor)(localVariableInstruction);
        }

        public static void VisitMethodInstruction(
            IMethodInstruction methodInstruction,
            IILInstructionVisitor visitor)
        {
            methodInstructionVisitor[methodInstruction.InstructionType](visitor)(methodInstruction);
        }

        public static void VisitShortBranchTargetInstruction(
            IShortBranchTargetInstruction shortBranchTargetInstruction,
            IILInstructionVisitor visitor)
        {
            shortBranchTargetInstructionVisitor[shortBranchTargetInstruction.InstructionType](visitor)(shortBranchTargetInstruction);
        }

        public static void VisitShortLocalVariableInstruction(
            IShortLocalVariableInstruction shortLocalVariableInstruction,
            IILInstructionVisitor visitor)
        {
            shortLocalVariableInstructionVisitor[shortLocalVariableInstruction.InstructionType](visitor)(shortLocalVariableInstruction);
        }

        public static void VisitSimpleInstruction(ISimpleInstruction simpleInstruction, IILInstructionVisitor visitor)
        {
            simpleInstructionVisitor[simpleInstruction.InstructionType](visitor)(simpleInstruction);
        }

        public static void VisitTypeInstruction(ITypeInstruction typeInstruction, IILInstructionVisitor visitor)
        {
            typeInstructionVisitor[typeInstruction.InstructionType](visitor)(typeInstruction);
        }
    }
}
