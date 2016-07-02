using CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
