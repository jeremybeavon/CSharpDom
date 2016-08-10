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
            TestClassAsync(typeof(ClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithUnaryPlusOperatorOverload));
        }
    }
}
