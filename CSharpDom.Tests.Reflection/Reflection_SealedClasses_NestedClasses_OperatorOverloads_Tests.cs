using CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
