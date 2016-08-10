using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
