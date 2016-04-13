using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Indexers.ExplicitInterfaceIndexers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    public sealed partial class ClassNestedAbstractClassWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith1Attribute()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith2Parameters()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2Parameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParameters()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithParameters));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexerWith2ParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithReflectionWithNestedAbstractClassWithExplicitInterfaceIndexer()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithExplicitInterfaceIndexer));
        }
    }
}