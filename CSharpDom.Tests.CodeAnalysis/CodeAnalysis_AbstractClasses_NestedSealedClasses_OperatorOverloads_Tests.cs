using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
