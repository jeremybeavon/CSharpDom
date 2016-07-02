using CSharpDom.TestTarget.AbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
