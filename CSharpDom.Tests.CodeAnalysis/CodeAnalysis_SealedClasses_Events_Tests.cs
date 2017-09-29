using CSharpDom.TestTarget.SealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithPublicEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticEvent));
        }
    }
}
