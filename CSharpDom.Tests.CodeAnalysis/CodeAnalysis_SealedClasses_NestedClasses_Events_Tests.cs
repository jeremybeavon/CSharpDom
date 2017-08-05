using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEvent));
        }
    }
}
