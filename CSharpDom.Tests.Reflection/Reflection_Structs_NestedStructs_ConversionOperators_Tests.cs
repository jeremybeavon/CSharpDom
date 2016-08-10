using CSharpDom.TestTarget.Structs.NestedStructs.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedStructs_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
