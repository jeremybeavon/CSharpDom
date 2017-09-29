using CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
