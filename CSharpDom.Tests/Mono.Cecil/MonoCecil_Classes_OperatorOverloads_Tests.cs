using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
