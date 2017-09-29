using CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedSealedClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithInternalEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithOverrideEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPrivateEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithPublicEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithPublicEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestAbstractClassWithNestedSealedClassWithStaticEventUsingCodeAnalysis()
        {
            TestAbstractClassAsync(typeof(AbstractClassWithNestedSealedClassWithStaticEvent));
        }
    }
}
