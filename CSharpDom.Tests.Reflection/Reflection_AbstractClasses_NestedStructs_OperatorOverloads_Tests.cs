using CSharpDom.TestTarget.AbstractClasses.NestedStructs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedStructWithAndOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
