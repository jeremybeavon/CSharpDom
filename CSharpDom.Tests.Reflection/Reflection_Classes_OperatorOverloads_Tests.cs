using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithAndOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
