using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedAbstractClasses_ConversionOperators_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
