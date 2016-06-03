using CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
