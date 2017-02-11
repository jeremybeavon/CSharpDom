using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
