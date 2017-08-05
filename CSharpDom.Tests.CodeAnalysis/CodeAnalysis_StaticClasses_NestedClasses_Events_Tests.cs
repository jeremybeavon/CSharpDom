using CSharpDom.TestTarget.StaticClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithVirtualEvent));
        }
    }
}
