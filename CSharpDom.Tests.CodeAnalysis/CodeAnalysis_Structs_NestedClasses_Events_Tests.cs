using CSharpDom.TestTarget.Structs.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedClassWithVirtualEvent));
        }
    }
}
