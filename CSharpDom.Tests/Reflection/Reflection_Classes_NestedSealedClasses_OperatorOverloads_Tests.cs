using CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
