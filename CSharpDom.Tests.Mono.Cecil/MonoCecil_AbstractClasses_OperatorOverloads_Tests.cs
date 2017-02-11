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
            TestAbstractClass(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
