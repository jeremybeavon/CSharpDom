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
            TestClassAsync(typeof(ClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
