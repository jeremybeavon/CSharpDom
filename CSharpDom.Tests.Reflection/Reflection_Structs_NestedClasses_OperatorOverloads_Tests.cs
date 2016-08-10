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
            TestStructAsync(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
