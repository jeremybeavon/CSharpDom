using CSharpDom.TestTarget.AbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
