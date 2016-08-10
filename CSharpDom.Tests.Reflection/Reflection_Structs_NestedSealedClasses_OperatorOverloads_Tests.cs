using CSharpDom.TestTarget.Structs.NestedSealedClasses.OperatorOverloads;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_OperatorOverloads_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithAndOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithAndOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithBitwiseNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithBitwiseNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDecrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDecrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithDivideOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithDivideOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEqualAndNotEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithExclusiveOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithExclusiveOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithIncrementOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithIncrementOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLeftShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLeftShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanAndGreaterThanOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLessThanOrEqualAndGreaterThanOrEqualOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithLogicalNotOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithLogicalNotOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithModuloOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithModuloOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithMultiplyOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithMultiplyOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOrOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOrOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPlusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithRightShiftOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithRightShiftOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithTrueAndFalseOperatorOverloadsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithTrueAndFalseOperatorOverloads));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryMinusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryMinusOperatorOverload));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithUnaryPlusOperatorOverloadUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithUnaryPlusOperatorOverload));
        }
    }
}
