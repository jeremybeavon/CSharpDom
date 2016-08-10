using CSharpDom.TestTarget.Classes.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedAbstractClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
