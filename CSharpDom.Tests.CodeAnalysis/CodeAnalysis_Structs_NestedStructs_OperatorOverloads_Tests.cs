using CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
