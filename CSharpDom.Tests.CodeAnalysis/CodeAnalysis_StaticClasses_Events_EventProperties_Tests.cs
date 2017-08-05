using CSharpDom.TestTarget.StaticClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicEventProperty));
        }
    }
}
