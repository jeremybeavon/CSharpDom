using CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
