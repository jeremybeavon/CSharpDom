using CSharpDom.TestTarget.Structs.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithAndOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithDecrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithIncrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithModuloOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithUnaryPlusOperatorOverload));
        }
    }
}
