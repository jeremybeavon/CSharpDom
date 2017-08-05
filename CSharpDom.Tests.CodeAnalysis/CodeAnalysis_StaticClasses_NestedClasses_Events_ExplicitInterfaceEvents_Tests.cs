using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.ExplicitInterfaceEvents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Events_ExplicitInterfaceEvents_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithExplicitInterfaceEventWithGenericInterfaceUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithExplicitInterfaceEventWithGenericInterface));
        }
    }
}
