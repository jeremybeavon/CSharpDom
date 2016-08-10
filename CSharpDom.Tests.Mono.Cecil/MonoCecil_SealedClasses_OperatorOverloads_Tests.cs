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
            TestSealedClassAsync(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
