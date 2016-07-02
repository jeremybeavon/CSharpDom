using CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
