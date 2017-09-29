using CSharpDom.TestTarget.SealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
