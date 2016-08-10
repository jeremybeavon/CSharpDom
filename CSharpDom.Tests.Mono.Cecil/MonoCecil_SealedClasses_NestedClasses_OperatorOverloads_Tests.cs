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
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
