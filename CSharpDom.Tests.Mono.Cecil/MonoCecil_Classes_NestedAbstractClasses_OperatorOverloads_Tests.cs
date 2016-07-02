using CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
