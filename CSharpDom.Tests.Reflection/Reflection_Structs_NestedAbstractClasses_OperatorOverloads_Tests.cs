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
            TestStructAsync(typeof(StructWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
