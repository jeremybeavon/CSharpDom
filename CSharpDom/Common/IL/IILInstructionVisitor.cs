namespace CSharpDom.Common.IL
{
    public interface IILInstructionVisitor
    {
        void Visit(IILInstruction instruction);

        void VisitAddInstruction(ISimpleInstruction instruction);

        void VisitAddUnsignedWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitAddWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitAllocateLocalMemoryInstruction(ISimpleInstruction instruction);

        void VisitArgListInstruction(ISimpleInstruction instruction);

        void VisitBitwiseAndInstruction(ISimpleInstruction instruction);

        void VisitBitwiseNotInstruction(ISimpleInstruction instruction);

        void VisitBitwiseOrInstruction(ISimpleInstruction instruction);

        void VisitBitwiseXorInstruction(ISimpleInstruction instruction);

        void VisitBoxInstruction(ITypeInstruction instruction);

        void VisitBranchInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfEqualInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfEqualInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfFalseInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfFalseInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanOrEqualInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanOrEqualInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanOrEqualUnsignedInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanOrEqualUnsignedInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanUnsignedInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfGreaterThanUnsignedInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfLessThanInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfLessThanInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfLessThanOrEqualInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfLessThanOrEqualInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfLessThanOrEqualUnsignedInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfLessThanOrEqualUnsignedInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfLessThanUnsignedInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfLessThanUnsignedInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfNotEqualInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfNotEqualInstruction(IBranchTargetInstruction instruction);

        void VisitBranchIfTrueInstruction(IShortBranchTargetInstruction instruction);

        void VisitBranchIfTrueInstruction(IBranchTargetInstruction instruction);

        void VisitCallMethodInstruction(IMethodInstruction instruction);

        void VisitCallVirtualMethodInstruction(IMethodInstruction instruction);

        void VisitCastInstruction(ITypeInstruction instruction);

        void VisitCheckFiniteInstruction(ISimpleInstruction instruction);

        void VisitConstrainedInstruction(ITypeInstruction instruction);

        void VisitConvertSignedValueToByteWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToLongWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToShortWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToUnsignedByteWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToUnsignedIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToUnsignedLongWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToUnsignedNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertSignedValueToUnsignedShortWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToByteWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToFloatInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToLongWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToShortWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToUnsignedByteWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToUnsignedIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToUnsignedLongWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToUnsignedNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertUnsignedValueToUnsignedShortWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToByteInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToDoubleInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToFloatInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToIntegerInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToLongInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToNativeIntegerInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToShortInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToUnsignedByteInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToUnsignedIntegerInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToUnsignedLongInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToUnsignedNativeIntegerInstruction(ISimpleInstruction instruction);

        void VisitConvertValueToUnsignedShortInstruction(ISimpleInstruction instruction);

        void VisitCopyMemoryBlockInstruction(ISimpleInstruction instruction);

        void VisitCopyObjectInstruction(ITypeInstruction instruction);

        void VisitDebuggingBreakInstruction(ISimpleInstruction instruction);

        void VisitDivideInstruction(ISimpleInstruction instruction);

        void VisitDivideUnsignedInstruction(ISimpleInstruction instruction);

        void VisitDuplicateValueInstruction(ISimpleInstruction instruction);

        void VisitEndFilterInstruction(ISimpleInstruction instruction);

        void VisitEndFinallyInstruction(ISimpleInstruction instruction);

        void VisitEqualInstruction(ISimpleInstruction instruction);

        void VisitGreaterThanInstruction(ISimpleInstruction instruction);

        void VisitGreaterThanUnsignedInstruction(ISimpleInstruction instruction);

        void VisitInitializeMemoryBlockInstruction(ISimpleInstruction instruction);

        void VisitInitializeObjectInstruction(ITypeInstruction instruction);

        void VisitIsInstanceOfClassInstruction(ITypeInstruction instruction);

        void VisitJumpInstruction(IMethodInstruction instruction);

        void VisitLeaveInstruction(IShortBranchTargetInstruction instruction);

        void VisitLeaveInstruction(IBranchTargetInstruction instruction);

        void VisitLeftShiftInstruction(ISimpleInstruction instruction);

        void VisitLessThanInstruction(ISimpleInstruction instruction);

        void VisitLessThanUnsignedInstruction(ISimpleInstruction instruction);

        void VisitLoadAddressInstruction(ITypeInstruction instruction);

        void VisitLoadArgumentInstruction(ILocalVariableInstruction instruction);

        void VisitLoadArgumentInstruction(IShortLocalVariableInstruction instruction);

        void VisitLoadArgument0Instruction(ISimpleInstruction instruction);

        void VisitLoadArgument1Instruction(ISimpleInstruction instruction);

        void VisitLoadArgument2Instruction(ISimpleInstruction instruction);

        void VisitLoadArgument3Instruction(ISimpleInstruction instruction);

        void VisitLoadArgumentAddressInstruction(ILocalVariableInstruction instruction);

        void VisitLoadArgumentAddressInstruction(IShortLocalVariableInstruction instruction);

        void VisitLoadArrayElementInstruction(ITypeInstruction instruction);

        void VisitLoadArrayElementAddressInstruction(ITypeInstruction instruction);

        void VisitLoadArrayLengthInstruction(ISimpleInstruction instruction);

        void VisitLoadByteArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadByteIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadByteInstruction(ILoadByteInstruction instruction);

        void VisitLoadDoubleArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadDoubleIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadDoubleInstruction(ILoadDoubleInstruction instruction);

        void VisitLoadFieldInstruction(IFieldInstruction instruction);

        void VisitLoadFieldAddressInstruction(IFieldInstruction instruction);

        void VisitLoadFloatArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadFloatIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadFloatInstruction(ILoadFloatInstruction instruction);

        void VisitLoadIntegerInstruction(ILoadIntegerInstruction instruction);

        void VisitLoadInteger0Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger1Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger2Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger3Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger4Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger5Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger6Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger7Instruction(ISimpleInstruction instruction);

        void VisitLoadInteger8Instruction(ISimpleInstruction instruction);

        void VisitLoadIntegerArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadIntegerIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadIntegerNegative1Instruction(ISimpleInstruction instruction);

        void VisitLoadLocalVariableInstruction(ILocalVariableInstruction instruction);

        void VisitLoadLocalVariableInstruction(IShortLocalVariableInstruction instruction);

        void VisitLoadLocalVariable0Instruction(ISimpleInstruction instruction);

        void VisitLoadLocalVariable1Instruction(ISimpleInstruction instruction);

        void VisitLoadLocalVariable2Instruction(ISimpleInstruction instruction);

        void VisitLoadLocalVariable3Instruction(ISimpleInstruction instruction);

        void VisitLoadLocalVariableAddressInstruction(ILocalVariableInstruction instruction);

        void VisitLoadLocalVariableAddressInstruction(IShortLocalVariableInstruction instruction);

        void VisitLoadLongArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadLongIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadLongInstruction(ILoadLongInstruction instruction);

        void VisitLoadMemberTokenInstruction(ILoadMemberTokenInstruction instruction);

        void VisitLoadNativeIntArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadNativeIntegerIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadNullInstruction(ISimpleInstruction instruction);

        void VisitLoadObjectInstruction(ITypeInstruction instruction);

        void VisitLoadObjectReferenceArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadObjectReferenceIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadPointerInstruction(IMethodInstruction instruction);

        void VisitLoadShortArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadShortIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadStaticFieldInstruction(IFieldInstruction instruction);

        void VisitLoadStaticFieldAddressInstruction(IFieldInstruction instruction);

        void VisitLoadStringInstruction(ILoadStringInstruction instruction);

        void VisitLoadTypeInstruction(ISimpleInstruction instruction);

        void VisitLoadTypeInstruction(ITypeInstruction instruction);

        void VisitLoadTypeReferenceInstruction(ITypeInstruction instruction);

        void VisitLoadUnsignedByteArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadUnsignedByteIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadUnsignedIntegerArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadUnsignedIntegerIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadUnsignedShortArrayElementInstruction(ISimpleInstruction instruction);

        void VisitLoadUnsignedShortIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitLoadVirtualPointerInstruction(IMethodInstruction instruction);

        void VisitModuloInstruction(ISimpleInstruction instruction);

        void VisitModuloUnsignedInstruction(ISimpleInstruction instruction);

        void VisitMultiplyInstruction(ISimpleInstruction instruction);

        void VisitMultiplyUnsignedWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitMultiplyWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitNegateInstruction(ISimpleInstruction instruction);

        void VisitNewArrayInstruction(ITypeInstruction instruction);

        void VisitNewObjectInstruction(IMethodInstruction instruction);

        void VisitNoOperationInstruction(ISimpleInstruction instruction);

        void VisitPopInstruction(ISimpleInstruction instruction);

        void VisitReadOnlyInstruction(ISimpleInstruction instruction);

        void VisitRethrowInstruction(ISimpleInstruction instruction);

        void VisitReturnInstruction(ISimpleInstruction instruction);

        void VisitRightShiftInstruction(ISimpleInstruction instruction);

        void VisitRightShiftUnsignedInstruction(ISimpleInstruction instruction);

        void VisitSizeOfInstruction(ITypeInstruction instruction);

        void VisitStoreArgumentInstruction(ILocalVariableInstruction instruction);

        void VisitStoreArgumentInstruction(IShortLocalVariableInstruction instruction);

        void VisitStoreArrayElementInstruction(ITypeInstruction instruction);

        void VisitStoreByteArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreByteIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreDoubleArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreDoubleIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreFieldInstruction(IFieldInstruction instruction);

        void VisitStoreFloatArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreFloatIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreIntegerArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreIntegerIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreLocalVariableInstruction(ILocalVariableInstruction instruction);

        void VisitStoreLocalVariableInstruction(IShortLocalVariableInstruction instruction);

        void VisitStoreLocalVariable0Instruction(ISimpleInstruction instruction);

        void VisitStoreLocalVariable1Instruction(ISimpleInstruction instruction);

        void VisitStoreLocalVariable2Instruction(ISimpleInstruction instruction);

        void VisitStoreLocalVariable3Instruction(ISimpleInstruction instruction);

        void VisitStoreLongArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreLongIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreNativeIntegerArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreNativeIntegerIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreObjectInstruction(ITypeInstruction instruction);

        void VisitStoreObjectReferenceArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreObjectReferenceIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreShortArrayElementInstruction(ISimpleInstruction instruction);

        void VisitStoreShortIndirectlyInstruction(ISimpleInstruction instruction);

        void VisitStoreStaticFieldInstruction(IFieldInstruction instruction);

        void VisitSubtractInstruction(ISimpleInstruction instruction);

        void VisitSubtractUnsignedWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitSubtractWithOverflowCheckInstruction(ISimpleInstruction instruction);

        void VisitSwitchInstruction(ISwitchInstruction instruction);

        void VisitTailCallInstruction(ISimpleInstruction instruction);

        void VisitThrowInstruction(ISimpleInstruction instruction);

        void VisitUnalignedInstruction(IUnalignedInstruction instruction);

        void VisitUnboxInstruction(ITypeInstruction instruction);

        void VisitUnboxAnyInstruction(ITypeInstruction instruction);

        void VisitVolatileInstruction(ISimpleInstruction instruction);
    }
}
