using CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
