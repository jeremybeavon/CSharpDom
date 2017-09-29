using CSharpDom.TestTarget.Structs.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStructWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            TestStructAsync(typeof(StructWithNestedSealedClassWithStaticEvent));
        }
    }
}
