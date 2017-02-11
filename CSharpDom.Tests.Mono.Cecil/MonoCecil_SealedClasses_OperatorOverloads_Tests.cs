using CSharpDom.TestTarget.SealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
