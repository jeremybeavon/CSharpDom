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
            TestStruct(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
