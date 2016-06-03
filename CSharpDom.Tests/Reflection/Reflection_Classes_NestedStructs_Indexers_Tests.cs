using CSharpDom.TestTarget.Classes.NestedStructs.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedStructs_Indexers_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith1AccessorAttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2ParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2ParametersWithParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithIndexerWith2ParametersWithModifiersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithInternalIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPrivateIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithNestedStructWithPublicIndexerUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedStructWithPublicIndexer));
        }
    }
}
