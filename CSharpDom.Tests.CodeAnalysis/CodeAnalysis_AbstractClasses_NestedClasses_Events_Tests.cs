using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEvent));
        }
    }
}
