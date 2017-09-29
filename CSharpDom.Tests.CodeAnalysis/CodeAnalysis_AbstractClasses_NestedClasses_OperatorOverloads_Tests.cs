using CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
