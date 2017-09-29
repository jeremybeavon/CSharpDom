using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithInternalEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithPublicEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithStaticEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedClassWithVirtualEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualEvent));
        }
    }
}
