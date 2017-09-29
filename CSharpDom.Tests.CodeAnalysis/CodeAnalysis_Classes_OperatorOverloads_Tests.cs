using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
