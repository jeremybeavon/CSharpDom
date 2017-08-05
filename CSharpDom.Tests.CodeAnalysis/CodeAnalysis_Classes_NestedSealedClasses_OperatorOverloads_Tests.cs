using CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
