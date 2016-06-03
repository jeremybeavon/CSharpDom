using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithAndOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
