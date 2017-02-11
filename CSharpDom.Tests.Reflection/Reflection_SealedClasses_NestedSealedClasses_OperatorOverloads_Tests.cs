using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
