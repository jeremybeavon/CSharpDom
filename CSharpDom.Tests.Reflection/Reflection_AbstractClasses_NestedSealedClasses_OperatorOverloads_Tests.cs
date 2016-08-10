using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
