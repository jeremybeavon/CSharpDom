using CSharpDom.TestTarget.SealedClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
