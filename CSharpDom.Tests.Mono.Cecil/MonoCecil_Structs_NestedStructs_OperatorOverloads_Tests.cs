using CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
