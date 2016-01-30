using System;
using CSharpDom.Common.IL;

namespace CSharpDom.BaseClasses.IL
{
    public abstract class AbstractILInstructionVisitor : IILInstructionVisitor
    {
        public virtual void Visit(IILInstruction instruction)
        {
        }

        public virtual void VisitAddInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitAddUnsignedWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitAddWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitAllocateLocalMemoryInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitArgListInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBitwiseAndInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBitwiseNotInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBitwiseOrInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBitwiseXorInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBoxInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfEqualInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfEqualInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfFalseInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfFalseInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanOrEqualInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanOrEqualInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanOrEqualUnsignedInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanOrEqualUnsignedInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanUnsignedInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfGreaterThanUnsignedInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanOrEqualInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanOrEqualInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanOrEqualUnsignedInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanOrEqualUnsignedInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanUnsignedInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfLessThanUnsignedInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfNotEqualInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfNotEqualInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfTrueInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitBranchIfTrueInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitCallMethodInstruction(IMethodInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitCallVirtualMethodInstruction(IMethodInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitCastInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitCheckFiniteInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConstrainedInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToByteWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToLongWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToShortWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToUnsignedByteWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToUnsignedIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToUnsignedLongWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToUnsignedNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertSignedValueToUnsignedShortWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToByteWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToFloatInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToLongWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToShortWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToUnsignedByteWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToUnsignedIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToUnsignedLongWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToUnsignedNativeIntegerWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertUnsignedValueToUnsignedShortWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToByteInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToDoubleInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToFloatInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToIntegerInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToLongInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToNativeIntegerInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToShortInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToUnsignedByteInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToUnsignedIntegerInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToUnsignedLongInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToUnsignedNativeIntegerInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitConvertValueToUnsignedShortInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitCopyMemoryBlockInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitCopyObjectInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitDebuggingBreakInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitDivideInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitDivideUnsignedInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitDuplicateValueInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitEndFilterInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitEndFinallyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitEqualInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitGreaterThanInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitGreaterThanUnsignedInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitInitializeMemoryBlockInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitInitializeObjectInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitIsInstanceOfClassInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitJumpInstruction(IMethodInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLeaveInstruction(IBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLeaveInstruction(IShortBranchTargetInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLeftShiftInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLessThanInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLessThanUnsignedInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadAddressInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgumentInstruction(IShortLocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgumentInstruction(ILocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgument0Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgument1Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgument2Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgument3Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgumentAddressInstruction(IShortLocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArgumentAddressInstruction(ILocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArrayElementInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArrayElementAddressInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadArrayLengthInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadByteArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadByteIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadDoubleArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadDoubleIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadFieldInstruction(IFieldInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadFieldAddressInstruction(IFieldInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadFloatArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadFloatIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger0Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger1Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger2Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger3Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger4Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger5Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger6Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger7Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadInteger8Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadIntegerArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadIntegerIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadIntegerNegative1Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariableInstruction(IShortLocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariableInstruction(ILocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariable0Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariable1Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariable2Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariable3Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariableAddressInstruction(IShortLocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLocalVariableAddressInstruction(ILocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLongArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLongIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadNativeIntArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadNativeIntegerIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadNullInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadObjectInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadObjectReferenceArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadObjectReferenceIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadPointerInstruction(IMethodInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadShortArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadShortIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadStaticFieldInstruction(IFieldInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadStaticFieldAddressInstruction(IFieldInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadTypeInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadTypeInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadTypeReferenceInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadUnsignedByteArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadUnsignedByteIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadUnsignedIntegerArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadUnsignedIntegerIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadUnsignedShortArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadUnsignedShortIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadVirtualPointerInstruction(IMethodInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitModuloInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitModuloUnsignedInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitMultiplyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitMultiplyUnsignedWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitMultiplyWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitNegateInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitNewArrayInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitNewObjectInstruction(IMethodInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitNoOperationInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitPopInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitReadOnlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitRethrowInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitReturnInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitRightShiftInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitRightShiftUnsignedInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitSizeOfInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreArgumentInstruction(IShortLocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreArgumentInstruction(ILocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreArrayElementInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreByteArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreByteIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreDoubleArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreDoubleIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreFieldInstruction(IFieldInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreFloatArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreFloatIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreIntegerArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreIntegerIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLocalVariableInstruction(IShortLocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLocalVariableInstruction(ILocalVariableInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLocalVariable0Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLocalVariable1Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLocalVariable2Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLocalVariable3Instruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLongArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreLongIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreNativeIntegerArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreNativeIntegerIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreObjectInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreObjectReferenceArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreObjectReferenceIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreShortArrayElementInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreShortIndirectlyInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitStoreStaticFieldInstruction(IFieldInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitSubtractInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitSubtractUnsignedWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitSubtractWithOverflowCheckInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitTailCallInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitThrowInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitUnboxInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitUnboxAnyInstruction(ITypeInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitVolatileInstruction(ISimpleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadByteInstruction(ILoadByteInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadDoubleInstruction(ILoadDoubleInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadFloatInstruction(ILoadFloatInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadIntegerInstruction(ILoadIntegerInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadLongInstruction(ILoadLongInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadStringInstruction(ILoadStringInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitUnalignedInstruction(IUnalignedInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitSwitchInstruction(ISwitchInstruction instruction)
        {
            Visit(instruction);
        }

        public virtual void VisitLoadMemberTokenInstruction(ILoadMemberTokenInstruction instruction)
        {
            Visit(instruction);
        }
    }
}
