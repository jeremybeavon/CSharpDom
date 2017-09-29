using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.Events;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_NestedAbstractClasses_Events_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEventWith1AttributeUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWith1Attribute));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithEventWithGenericDelegateUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithEventWithGenericDelegate));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithInternalEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewStaticEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithNewVirtualEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNewVirtualEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithOverrideEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPrivateEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithProtectedInternalEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithPublicEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithSealedOverrideEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithSealedOverrideEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithStaticEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithStaticEvent));
        }

        [TestMethod]
        public void TestStaticClassWithNestedAbstractClassWithVirtualEventUsingCodeAnalysis()
        {
            TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithVirtualEvent));
        }
    }
}
