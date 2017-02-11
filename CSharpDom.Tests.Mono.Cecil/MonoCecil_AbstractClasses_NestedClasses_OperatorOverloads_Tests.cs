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
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
