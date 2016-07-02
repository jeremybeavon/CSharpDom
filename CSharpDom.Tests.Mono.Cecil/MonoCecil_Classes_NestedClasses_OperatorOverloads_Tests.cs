using CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
