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
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestAbstractClass(typeof(AbstractClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
