using CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
