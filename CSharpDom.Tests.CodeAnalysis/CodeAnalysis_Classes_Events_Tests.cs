using CSharpDom.TestTarget.Classes.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithPublicEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithVirtualEvent));
        }
    }
}
