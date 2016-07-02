using CSharpDom.TestTarget.AbstractClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
