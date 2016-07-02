using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
