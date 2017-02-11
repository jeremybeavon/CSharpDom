using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
