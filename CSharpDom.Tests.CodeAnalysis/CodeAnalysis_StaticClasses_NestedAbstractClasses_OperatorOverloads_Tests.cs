using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
