using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
