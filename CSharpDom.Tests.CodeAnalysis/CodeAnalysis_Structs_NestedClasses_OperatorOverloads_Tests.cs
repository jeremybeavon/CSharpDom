using CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
