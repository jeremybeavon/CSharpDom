using CSharpDom.TestTarget.SealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestSealedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestSealedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestSealedClassAsync(typeof(SealedClassWithStaticEvent));
        }
    }
}
