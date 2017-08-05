using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
