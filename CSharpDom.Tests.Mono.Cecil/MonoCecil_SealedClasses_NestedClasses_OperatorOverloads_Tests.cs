using CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
