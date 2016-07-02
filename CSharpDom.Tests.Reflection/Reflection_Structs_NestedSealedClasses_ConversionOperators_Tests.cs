using CSharpDom.TestTarget.Structs.NestedSealedClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Structs_NestedSealedClasses_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
