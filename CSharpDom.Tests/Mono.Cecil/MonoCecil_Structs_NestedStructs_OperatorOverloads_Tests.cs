using CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
