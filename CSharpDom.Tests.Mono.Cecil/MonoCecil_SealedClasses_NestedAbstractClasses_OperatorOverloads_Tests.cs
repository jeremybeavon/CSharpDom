using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
