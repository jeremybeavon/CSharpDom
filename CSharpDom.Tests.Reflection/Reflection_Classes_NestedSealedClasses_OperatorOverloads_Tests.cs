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
            TestClassAsync(typeof(ClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
