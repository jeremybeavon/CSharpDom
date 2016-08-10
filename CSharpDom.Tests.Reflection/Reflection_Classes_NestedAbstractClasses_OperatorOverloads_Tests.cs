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
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
