using CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
