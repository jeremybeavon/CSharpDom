using CSharpDom.TestTarget.SealedClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
