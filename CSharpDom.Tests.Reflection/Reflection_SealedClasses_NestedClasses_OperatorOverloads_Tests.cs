using CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
