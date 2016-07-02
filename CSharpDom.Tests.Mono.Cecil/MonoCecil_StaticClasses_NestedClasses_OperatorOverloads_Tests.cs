using CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
