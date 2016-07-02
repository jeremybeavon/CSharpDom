using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
