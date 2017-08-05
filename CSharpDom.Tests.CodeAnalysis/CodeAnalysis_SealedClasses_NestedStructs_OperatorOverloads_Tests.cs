using CSharpDom.TestTarget.SealedClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
