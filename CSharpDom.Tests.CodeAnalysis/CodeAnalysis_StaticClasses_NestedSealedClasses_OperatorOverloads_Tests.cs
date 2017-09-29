using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
