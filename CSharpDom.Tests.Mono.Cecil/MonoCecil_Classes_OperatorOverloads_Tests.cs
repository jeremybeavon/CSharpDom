using CSharpDom.TestTarget.Classes.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
