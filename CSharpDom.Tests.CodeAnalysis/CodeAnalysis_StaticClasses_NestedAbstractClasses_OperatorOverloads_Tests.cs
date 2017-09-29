using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
