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
            TestStructAsync(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
