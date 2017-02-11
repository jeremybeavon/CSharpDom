using CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithAndOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
