using CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
