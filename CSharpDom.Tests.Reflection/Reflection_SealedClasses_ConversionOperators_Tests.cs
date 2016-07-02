using CSharpDom.TestTarget.SealedClasses.ConversionOperators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_ConversionOperators_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithExplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperator));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith1ParameterAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith1ParameterAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith1ReturnAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith2ParameterAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithImplicitConversionOperatorWith2ReturnAttributesIn2AttributeGroups));
        }
    }
}
