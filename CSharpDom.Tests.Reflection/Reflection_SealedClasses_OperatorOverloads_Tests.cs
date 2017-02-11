using CSharpDom.TestTarget.SealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
