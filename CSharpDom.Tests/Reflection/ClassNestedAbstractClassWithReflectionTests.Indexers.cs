using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedAbstractClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWithWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWithWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWith2ParametersWithParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithInternalIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithNewVirtualIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithOverrideIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPrivateIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithProtectedInternalIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithPublicIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithSealedOverrideIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideIndexer));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithVirtualIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualIndexer));
        }
    }
}