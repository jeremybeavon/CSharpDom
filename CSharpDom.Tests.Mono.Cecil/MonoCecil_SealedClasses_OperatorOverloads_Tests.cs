using CSharpDom.TestTarget.SealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
