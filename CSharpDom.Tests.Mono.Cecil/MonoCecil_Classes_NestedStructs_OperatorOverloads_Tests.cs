using CSharpDom.TestTarget.Classes.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedStructWithAndOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
