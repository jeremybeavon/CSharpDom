using CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
