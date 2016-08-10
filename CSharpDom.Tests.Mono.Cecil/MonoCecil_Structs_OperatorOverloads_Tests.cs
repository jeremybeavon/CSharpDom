using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithAndOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithAndOperator));
        }

        [TestMethod]
        public void TestStructWithBitwiseNotOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithBitwiseNotOperator));
        }

        [TestMethod]
        public void TestStructWithDecrementOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithDecrementOperator));
        }

        [TestMethod]
        public void TestStructWithEqualAndNotEqualOperatorsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithEqualAndNotEqualOperators));
        }

        [TestMethod]
        public void TestStructWithExclusiveOrOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithExclusiveOrOperator));
        }

        [TestMethod]
        public void TestStructWithIncrementOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithIncrementOperator));
        }

        [TestMethod]
        public void TestStructWithLeftShiftOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLeftShiftOperator));
        }

        [TestMethod]
        public void TestStructWithLessThanAndGreaterThanOperatorsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperators));
        }

        [TestMethod]
        public void TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperators));
        }

        [TestMethod]
        public void TestStructWithLogicalNotOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLogicalNotOperator));
        }

        [TestMethod]
        public void TestStructWithMinusOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithMinusOperator));
        }

        [TestMethod]
        public void TestStructWithModuloOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithModuloOperator));
        }

        [TestMethod]
        public void TestStructWithMultiplyOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithMultiplyOperator));
        }

        [TestMethod]
        public void TestStructWithOrOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithOrOperator));
        }

        [TestMethod]
        public void TestStructWithPlusOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPlusOperator));
        }

        [TestMethod]
        public void TestStructWithRightShiftOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithRightShiftOperator));
        }

        [TestMethod]
        public void TestStructWithTrueAndFalseOperatorsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithTrueAndFalseOperators));
        }

        [TestMethod]
        public void TestStructWithUnaryMinusOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithUnaryMinusOperator));
        }

        [TestMethod]
        public void TestStructWithUnaryPlusOperatorUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithUnaryPlusOperator));
        }
    }
}
