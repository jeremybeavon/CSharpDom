using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
