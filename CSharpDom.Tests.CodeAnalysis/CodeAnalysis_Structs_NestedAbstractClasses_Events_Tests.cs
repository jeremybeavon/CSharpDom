using CSharpDom.TestTarget.Structs.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedAbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
