using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
