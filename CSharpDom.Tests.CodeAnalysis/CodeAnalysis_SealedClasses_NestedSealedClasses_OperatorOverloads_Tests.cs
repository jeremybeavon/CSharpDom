using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
