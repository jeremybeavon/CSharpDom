using CSharpDom.TestTarget.Classes.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Classes_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
