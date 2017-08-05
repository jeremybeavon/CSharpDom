using CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
