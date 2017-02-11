using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithAndOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOrOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStaticClass(typeof(StaticClassWithNestedAbstractClassWithUnaryPlusOperatorOverload));
        }
    }
}
