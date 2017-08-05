using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithUnaryPlusOperatorOverload));
        }
    }
}
