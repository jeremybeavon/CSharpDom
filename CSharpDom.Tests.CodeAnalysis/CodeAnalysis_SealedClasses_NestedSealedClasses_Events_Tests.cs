using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
