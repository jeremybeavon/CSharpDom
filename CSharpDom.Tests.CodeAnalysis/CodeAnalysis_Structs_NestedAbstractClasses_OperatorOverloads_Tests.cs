using CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
