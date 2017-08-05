using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedStaticClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicEventProperty));
        }
    }
}
