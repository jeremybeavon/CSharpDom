using CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
