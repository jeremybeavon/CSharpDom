using CSharpDom.TestTarget.Classes.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualEvent));
        }
    }
}
