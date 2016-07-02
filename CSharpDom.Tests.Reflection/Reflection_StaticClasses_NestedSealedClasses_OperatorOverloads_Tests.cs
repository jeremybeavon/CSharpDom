using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
