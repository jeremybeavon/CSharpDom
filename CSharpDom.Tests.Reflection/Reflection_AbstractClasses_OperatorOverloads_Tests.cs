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
            TestAbstractClassAsync(typeof(AbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
