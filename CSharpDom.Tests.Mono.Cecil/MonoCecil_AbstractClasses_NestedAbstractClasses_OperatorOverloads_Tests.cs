using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
