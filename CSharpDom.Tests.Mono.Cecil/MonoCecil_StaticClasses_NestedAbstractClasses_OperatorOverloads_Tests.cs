using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
