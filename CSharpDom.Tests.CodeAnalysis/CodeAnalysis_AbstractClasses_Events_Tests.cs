using CSharpDom.TestTarget.AbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithVirtualEvent));
        }
    }
}
