using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
