using CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
