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
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
