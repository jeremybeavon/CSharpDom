using CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
