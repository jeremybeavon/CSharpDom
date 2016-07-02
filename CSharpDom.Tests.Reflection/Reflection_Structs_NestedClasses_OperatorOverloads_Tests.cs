using CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
