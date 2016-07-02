using CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
