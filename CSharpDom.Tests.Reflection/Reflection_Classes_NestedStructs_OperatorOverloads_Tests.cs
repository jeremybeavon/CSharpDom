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
            TestClassAsync(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
