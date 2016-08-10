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
            TestClassAsync(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
