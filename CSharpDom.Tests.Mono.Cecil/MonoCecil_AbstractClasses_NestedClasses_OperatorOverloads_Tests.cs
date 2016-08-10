using CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
