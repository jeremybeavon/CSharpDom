using CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_ConversionOperators_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
