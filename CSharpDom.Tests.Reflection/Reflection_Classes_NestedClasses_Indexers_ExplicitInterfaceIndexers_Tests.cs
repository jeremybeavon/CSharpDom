using CSharpDom.TestTarget.Classes.NestedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_Indexers_ExplicitInterfaceIndexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithExplicitInterfaceIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithExplicitInterfaceIndexer));
        }
    }
}
