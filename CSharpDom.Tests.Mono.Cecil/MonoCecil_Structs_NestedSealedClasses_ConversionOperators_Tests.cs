using CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Structs_NestedSealedClasses_ConversionOperators_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
