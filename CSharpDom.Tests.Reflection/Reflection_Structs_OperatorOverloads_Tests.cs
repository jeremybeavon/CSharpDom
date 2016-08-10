using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithAndOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithAndOperator));
        }

        [TestMethod]
        public void TestStructWithBitwiseNotOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithBitwiseNotOperator));
        }

        [TestMethod]
        public void TestStructWithDecrementOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithDecrementOperator));
        }

        [TestMethod]
        public void TestStructWithEqualAndNotEqualOperatorsUsingReflection()
        {
            TestStructAsync(typeof(StructWithEqualAndNotEqualOperators));
        }

        [TestMethod]
        public void TestStructWithExclusiveOrOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithExclusiveOrOperator));
        }

        [TestMethod]
        public void TestStructWithIncrementOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithIncrementOperator));
        }

        [TestMethod]
        public void TestStructWithLeftShiftOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithLeftShiftOperator));
        }

        [TestMethod]
        public void TestStructWithLessThanAndGreaterThanOperatorsUsingReflection()
        {
            TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperators));
        }

        [TestMethod]
        public void TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorsUsingReflection()
        {
            TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperators));
        }

        [TestMethod]
        public void TestStructWithLogicalNotOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithLogicalNotOperator));
        }

        [TestMethod]
        public void TestStructWithMinusOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithMinusOperator));
        }

        [TestMethod]
        public void TestStructWithModuloOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithModuloOperator));
        }

        [TestMethod]
        public void TestStructWithMultiplyOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithMultiplyOperator));
        }

        [TestMethod]
        public void TestStructWithOrOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithOrOperator));
        }

        [TestMethod]
        public void TestStructWithPlusOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithPlusOperator));
        }

        [TestMethod]
        public void TestStructWithRightShiftOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithRightShiftOperator));
        }

        [TestMethod]
        public void TestStructWithTrueAndFalseOperatorsUsingReflection()
        {
            TestStructAsync(typeof(StructWithTrueAndFalseOperators));
        }

        [TestMethod]
        public void TestStructWithUnaryMinusOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithUnaryMinusOperator));
        }

        [TestMethod]
        public void TestStructWithUnaryPlusOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithUnaryPlusOperator));
        }
    }
}
