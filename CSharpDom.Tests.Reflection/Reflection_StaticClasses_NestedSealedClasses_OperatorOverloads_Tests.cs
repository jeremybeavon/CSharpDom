using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
