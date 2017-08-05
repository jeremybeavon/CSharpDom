using CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedAbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
