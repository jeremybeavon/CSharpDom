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
            TestClass(typeof(ClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedStructWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
