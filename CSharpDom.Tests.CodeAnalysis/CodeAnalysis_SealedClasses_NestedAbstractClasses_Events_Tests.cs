using CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_SealedClasses_NestedAbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestSealedClassWithNestedAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
