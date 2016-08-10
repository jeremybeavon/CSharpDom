using CSharpDom.TestTarget.Structs.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
