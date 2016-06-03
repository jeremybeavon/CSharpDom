using CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
