using CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWith2ParametersWithParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithIndexerWith2ParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithInternalIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithNewIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithOverrideIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPrivateIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithProtectedInternalIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithPublicIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithSealedOverrideIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideIndexer));
        }
    }
}