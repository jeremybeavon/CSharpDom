using CSharpDom.TestTarget.StaticClasses.NestedClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedClasses_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
