using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
