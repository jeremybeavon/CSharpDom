using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithUnaryPlusOperatorOverload));
        }
    }
}
