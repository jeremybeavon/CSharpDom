using CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
