using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
