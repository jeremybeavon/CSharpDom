using CSharpDom.TestTarget.SealedClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualEvent));
        }
    }
}
