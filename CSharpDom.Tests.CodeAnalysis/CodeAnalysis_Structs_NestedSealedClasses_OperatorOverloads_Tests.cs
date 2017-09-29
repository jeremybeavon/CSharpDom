using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
