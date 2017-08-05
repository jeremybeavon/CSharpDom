using CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
