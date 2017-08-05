using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events.EventProperties;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Events_EventProperties_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventPropertyWith1AccessorAttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1AccessorAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventPropertyWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AccessorAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventPropertyWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventPropertyWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEventProperty));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualEventPropertyUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEventProperty));
        }
    }
}
