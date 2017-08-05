using CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
