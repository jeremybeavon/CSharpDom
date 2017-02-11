using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithAndOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithModuloOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithOrOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStruct(typeof(StructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStruct(typeof(StructWithUnaryPlusOperatorOverload));
        }
    }
}
