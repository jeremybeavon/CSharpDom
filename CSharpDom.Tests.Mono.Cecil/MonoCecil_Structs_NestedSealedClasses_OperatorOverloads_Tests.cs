using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
