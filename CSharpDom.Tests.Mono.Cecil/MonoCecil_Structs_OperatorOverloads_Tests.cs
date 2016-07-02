using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithAndOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithAndOperator));
        }

        [TestMethod]
        public async Task TestStructWithBitwiseNotOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithBitwiseNotOperator));
        }

        [TestMethod]
        public async Task TestStructWithDecrementOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithDecrementOperator));
        }

        [TestMethod]
        public async Task TestStructWithEqualAndNotEqualOperatorsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithEqualAndNotEqualOperators));
        }

        [TestMethod]
        public async Task TestStructWithExclusiveOrOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithExclusiveOrOperator));
        }

        [TestMethod]
        public async Task TestStructWithIncrementOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithIncrementOperator));
        }

        [TestMethod]
        public async Task TestStructWithLeftShiftOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithLeftShiftOperator));
        }

        [TestMethod]
        public async Task TestStructWithLessThanAndGreaterThanOperatorsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperators));
        }

        [TestMethod]
        public async Task TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperators));
        }

        [TestMethod]
        public async Task TestStructWithLogicalNotOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithLogicalNotOperator));
        }

        [TestMethod]
        public async Task TestStructWithMinusOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithMinusOperator));
        }

        [TestMethod]
        public async Task TestStructWithModuloOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithModuloOperator));
        }

        [TestMethod]
        public async Task TestStructWithMultiplyOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithMultiplyOperator));
        }

        [TestMethod]
        public async Task TestStructWithOrOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithOrOperator));
        }

        [TestMethod]
        public async Task TestStructWithPlusOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithPlusOperator));
        }

        [TestMethod]
        public async Task TestStructWithRightShiftOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithRightShiftOperator));
        }

        [TestMethod]
        public async Task TestStructWithTrueAndFalseOperatorsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithTrueAndFalseOperators));
        }

        [TestMethod]
        public async Task TestStructWithUnaryMinusOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithUnaryMinusOperator));
        }

        [TestMethod]
        public async Task TestStructWithUnaryPlusOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithUnaryPlusOperator));
        }
    }
}
