using CSharpDom.TestTarget.StaticClasses.NestedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_OperatorOverloads_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedClassWithAndOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithBitwiseNotOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDecrementOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithDivideOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithExclusiveOrOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithIncrementOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLeftShiftOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloadsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithLogicalNotOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMinusOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithModuloOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithMultiplyOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithOrOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithPlusOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithRightShiftOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithTrueAndFalseOperatorOverloadsUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryMinusOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStaticClassWithNestedClassWithUnaryPlusOperatorOverloadUsingMonoCecil()
        {
            TestStaticClass(typeof(StaticClassWithNestedClassWithUnaryPlusOperatorOverload));
        }
    }
}
