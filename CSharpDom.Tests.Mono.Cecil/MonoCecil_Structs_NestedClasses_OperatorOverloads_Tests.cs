using CSharpDom.TestTarget.Structs.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
