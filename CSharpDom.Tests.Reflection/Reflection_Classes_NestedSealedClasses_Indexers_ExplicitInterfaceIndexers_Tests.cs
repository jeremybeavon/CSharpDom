using CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithExplicitInterfaceIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexer));
        }
    }
}
