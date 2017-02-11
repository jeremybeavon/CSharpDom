using CSharpDom.TestTarget.AbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
