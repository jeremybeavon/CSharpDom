using CSharpDom.TestTarget.Structs.NestedStructs.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_ConversionOperators_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith1ParameterAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperator));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith1ParameterAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith1ReturnAttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedStructWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
