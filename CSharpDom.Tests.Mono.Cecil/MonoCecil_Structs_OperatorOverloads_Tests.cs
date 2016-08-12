using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStructWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStructAsync(typeof(StructWithUnaryPlusOperatorOverload));
        }
    }
}
