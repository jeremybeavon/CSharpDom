using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
