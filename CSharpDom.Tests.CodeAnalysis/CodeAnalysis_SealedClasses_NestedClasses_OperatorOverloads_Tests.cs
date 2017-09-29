using CSharpDom.TestTarget.SealedClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
