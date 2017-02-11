using CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
