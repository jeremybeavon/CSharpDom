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
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedStructWithUnaryPlusOperatorOverload));
        }
    }
}
