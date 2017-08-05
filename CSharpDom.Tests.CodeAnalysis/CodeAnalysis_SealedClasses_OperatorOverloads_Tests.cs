using CSharpDom.TestTarget.SealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
