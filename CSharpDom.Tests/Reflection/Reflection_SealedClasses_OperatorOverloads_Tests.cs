using CSharpDom.TestTarget.SealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
