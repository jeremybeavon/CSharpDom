using CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
