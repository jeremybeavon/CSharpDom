using CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
