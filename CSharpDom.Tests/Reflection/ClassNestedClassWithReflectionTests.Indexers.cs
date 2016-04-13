using CSharpDom.TestTarget.Classes.NestedClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWith2ParametersWithParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithIndexerWith2ParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithInternalIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithNewVirtualIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithOverrideIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPrivateIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithProtectedInternalIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithPublicIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithSealedOverrideIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedClassWithVirtualIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualIndexer));
        }
    }
}