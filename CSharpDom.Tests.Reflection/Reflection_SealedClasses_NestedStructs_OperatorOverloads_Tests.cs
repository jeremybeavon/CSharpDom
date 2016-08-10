using CSharpDom.TestTarget.SealedClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
