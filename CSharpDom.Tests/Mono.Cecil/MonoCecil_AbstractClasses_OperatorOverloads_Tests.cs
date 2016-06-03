using CSharpDom.TestTarget.AbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
