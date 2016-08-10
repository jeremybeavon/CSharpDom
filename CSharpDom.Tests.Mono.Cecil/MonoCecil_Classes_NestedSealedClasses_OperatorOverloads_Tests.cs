using CSharpDom.TestTarget.Classes.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestClassWithNestedSealedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestClassAsync(typeof(ClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
