using CSharpDom.TestTarget.AbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithAndOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithBitwiseNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithDecrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithDivideOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithExclusiveOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithIncrementOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLeftShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithLogicalNotOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithModuloOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithMultiplyOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOrOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithRightShiftOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestAbstractClassWithUnaryMinusOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestAbstractClassWithUnaryPlusOperatorOverloadUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
