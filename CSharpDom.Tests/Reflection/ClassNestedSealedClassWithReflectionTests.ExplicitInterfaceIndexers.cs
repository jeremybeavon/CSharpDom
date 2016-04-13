using CSharpDom.TestTarget.Classes.NestedSealedClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedSealedClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedSealedClassWithExplicitInterfaceIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithExplicitInterfaceIndexer));
        }
    }
}