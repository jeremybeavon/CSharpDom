using CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
