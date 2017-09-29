using CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
