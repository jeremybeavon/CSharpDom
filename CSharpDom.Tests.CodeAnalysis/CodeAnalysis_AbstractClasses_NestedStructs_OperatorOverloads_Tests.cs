using CSharpDom.TestTarget.AbstractClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
