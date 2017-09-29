using CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
