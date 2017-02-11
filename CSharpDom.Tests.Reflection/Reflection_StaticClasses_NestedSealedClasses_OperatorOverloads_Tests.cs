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
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
