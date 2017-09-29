using CSharpDom.TestTarget.SealedClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
