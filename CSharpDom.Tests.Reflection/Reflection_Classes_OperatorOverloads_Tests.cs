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
            TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
