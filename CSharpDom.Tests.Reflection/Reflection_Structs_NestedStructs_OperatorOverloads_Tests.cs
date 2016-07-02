using CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
