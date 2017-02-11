using CSharpDom.TestTarget.Classes.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClass(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
