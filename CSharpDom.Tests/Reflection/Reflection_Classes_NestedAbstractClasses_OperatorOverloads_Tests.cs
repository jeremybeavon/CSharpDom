using CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
