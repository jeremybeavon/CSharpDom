using CSharpDom.TestTarget.SealedClasses.NestedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithExplicitInterfaceIndexerUsingReflection()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithExplicitInterfaceIndexer));
        }
    }
}
