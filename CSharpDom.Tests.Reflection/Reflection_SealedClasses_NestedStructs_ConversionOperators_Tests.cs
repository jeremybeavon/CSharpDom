using CSharpDom.TestTarget.SealedClasses.NestedStructs.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedStructs_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedStructWithExplicitConversionOperatorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithImplicitConversionOperatorUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
