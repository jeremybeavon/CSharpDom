using CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
