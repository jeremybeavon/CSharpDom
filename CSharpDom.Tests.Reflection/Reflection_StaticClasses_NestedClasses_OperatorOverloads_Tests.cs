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
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
