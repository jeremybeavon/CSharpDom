using CSharpDom.TestTarget.AbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
