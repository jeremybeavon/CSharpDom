using CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClass(typeof(ClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
