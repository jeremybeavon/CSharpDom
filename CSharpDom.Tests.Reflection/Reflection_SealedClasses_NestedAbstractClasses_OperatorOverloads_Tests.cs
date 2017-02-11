using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
