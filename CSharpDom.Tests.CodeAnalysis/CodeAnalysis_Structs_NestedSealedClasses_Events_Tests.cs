using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
