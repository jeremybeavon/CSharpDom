using CSharpDom.TestTarget.SealedClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
