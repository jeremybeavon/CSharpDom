using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public async Task TestStructWithNestedAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
