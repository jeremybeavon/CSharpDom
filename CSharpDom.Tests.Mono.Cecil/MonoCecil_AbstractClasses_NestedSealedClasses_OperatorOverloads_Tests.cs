using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
