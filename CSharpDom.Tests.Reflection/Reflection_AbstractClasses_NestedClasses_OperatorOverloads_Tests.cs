using CSharpDom.TestTarget.AbstractClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
