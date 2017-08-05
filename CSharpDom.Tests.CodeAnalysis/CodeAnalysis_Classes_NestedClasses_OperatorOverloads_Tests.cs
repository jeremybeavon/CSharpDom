using CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
