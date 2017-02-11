using CSharpDom.TestTarget.AbstractClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithAndOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
