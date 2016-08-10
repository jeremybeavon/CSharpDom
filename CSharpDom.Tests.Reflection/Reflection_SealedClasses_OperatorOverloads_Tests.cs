using CSharpDom.TestTarget.SealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
