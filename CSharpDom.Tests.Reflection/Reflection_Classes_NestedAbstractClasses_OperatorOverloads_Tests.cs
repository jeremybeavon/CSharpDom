using CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
