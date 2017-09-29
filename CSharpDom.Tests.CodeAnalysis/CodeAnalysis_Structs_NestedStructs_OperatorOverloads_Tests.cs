using CSharpDom.TestTarget.Structs.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
