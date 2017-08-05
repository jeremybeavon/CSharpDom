using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
