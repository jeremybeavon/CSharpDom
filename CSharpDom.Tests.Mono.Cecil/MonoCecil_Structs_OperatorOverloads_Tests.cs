using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithUnaryPlusOperatorOverload));
        }
    }
}
