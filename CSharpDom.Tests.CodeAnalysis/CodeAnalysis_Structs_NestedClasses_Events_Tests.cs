using CSharpDom.TestTarget.Structs.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
