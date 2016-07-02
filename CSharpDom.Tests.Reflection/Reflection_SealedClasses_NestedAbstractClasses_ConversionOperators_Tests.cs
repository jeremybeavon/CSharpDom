using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedAbstractClasses_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
