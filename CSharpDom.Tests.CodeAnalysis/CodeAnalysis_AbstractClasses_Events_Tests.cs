using CSharpDom.TestTarget.AbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithVirtualEvent));
        }
    }
}
