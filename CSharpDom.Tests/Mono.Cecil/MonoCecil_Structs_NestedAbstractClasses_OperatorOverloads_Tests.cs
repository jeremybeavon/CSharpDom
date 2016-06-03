using CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
