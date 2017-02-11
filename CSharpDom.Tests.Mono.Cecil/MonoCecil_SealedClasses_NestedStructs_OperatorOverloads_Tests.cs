using CSharpDom.TestTarget.SealedClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithAndOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
