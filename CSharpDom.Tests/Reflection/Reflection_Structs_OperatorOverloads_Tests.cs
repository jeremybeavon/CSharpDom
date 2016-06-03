using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithAndOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithAndOperator));
        }

        [TestMethod]
        public async Task TestStructWithBitwiseNotOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithBitwiseNotOperator));
        }

        [TestMethod]
        public async Task TestStructWithDecrementOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithDecrementOperator));
        }

        [TestMethod]
        public async Task TestStructWithEqualAndNotEqualOperatorsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithEqualAndNotEqualOperators));
        }

        [TestMethod]
        public async Task TestStructWithExclusiveOrOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithExclusiveOrOperator));
        }

        [TestMethod]
        public async Task TestStructWithIncrementOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithIncrementOperator));
        }

        [TestMethod]
        public async Task TestStructWithLeftShiftOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithLeftShiftOperator));
        }

        [TestMethod]
        public async Task TestStructWithLessThanAndGreaterThanOperatorsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperators));
        }

        [TestMethod]
        public async Task TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperators));
        }

        [TestMethod]
        public async Task TestStructWithLogicalNotOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithLogicalNotOperator));
        }

        [TestMethod]
        public async Task TestStructWithMinusOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithMinusOperator));
        }

        [TestMethod]
        public async Task TestStructWithModuloOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithModuloOperator));
        }

        [TestMethod]
        public async Task TestStructWithMultiplyOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithMultiplyOperator));
        }

        [TestMethod]
        public async Task TestStructWithOrOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithOrOperator));
        }

        [TestMethod]
        public async Task TestStructWithPlusOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithPlusOperator));
        }

        [TestMethod]
        public async Task TestStructWithRightShiftOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithRightShiftOperator));
        }

        [TestMethod]
        public async Task TestStructWithTrueAndFalseOperatorsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithTrueAndFalseOperators));
        }

        [TestMethod]
        public async Task TestStructWithUnaryMinusOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithUnaryMinusOperator));
        }

        [TestMethod]
        public async Task TestStructWithUnaryPlusOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithUnaryPlusOperator));
        }
    }
}
